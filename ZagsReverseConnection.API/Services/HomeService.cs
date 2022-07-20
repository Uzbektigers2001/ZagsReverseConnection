using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;
using ZagsReverseConnection.API.DbContexts;
using ZagsReverseConnection.API.Interfaces;
using ZagsReverseConnection.API.Models;

namespace ZagsReverseConnection.API.Services
{
    public class HomeService : IHomeService
    {
        private readonly ApplicationDBContext _dbcontext;

        public HomeService(ApplicationDBContext dBContext)
        {
            _dbcontext = dBContext;
        }

        public GetFamilyModel GetFamily(string PinFL)
        {
            try
            {
                string url = "http://10.190.24.138:7074/family-traversal/rest-api/by-pnfl/minfin/";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Basic TWlORmlubjpGaW5MYUxhbkQ=");
                var result = client.GetAsync(url + PinFL).Result.Content.ReadAsStringAsync().Result;
                result = result.Replace("event", "_event");

                var model = JsonConvert.DeserializeObject<GetFamilyModel>(result);

                return model;
            }
            catch
            {
                return new GetFamilyModel();
            }
        }

        public async Task<string> PostFamilyAsync(object family)
        {
            string ConString = "Server = SR_DB; Database = SingleRegistryProduction; User Id = sa; Password = DP_DD_projekte; Trusted_Connection = True;";

            try
            {
                GetFamilyModel? get = new GetFamilyModel();
                get = family is not null ? JsonConvert.DeserializeObject<GetFamilyModel>(family.ToString()) : new GetFamilyModel();

                PostModel? postModel = new PostModel();

                postModel = JsonConvert.DeserializeObject<PostModel>(JsonConvert.SerializeObject(get)
                    .Replace("pnfl", "pinfl")
                    .Replace("id", "person_id")
                    .Replace("memberNum", "member_num")
                    .Replace("patronym", "middlename")
                    .Replace("traversal", "familyMember")
                    .Replace("birthDate", "birthday"));
                postModel.result_code = 1;


                string url = "http://10.190.24.138:7074/family-traversal/rest-api/post-changed/minfin";
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Basic TWlORmlubjpGaW5MYUxhbkQ=");
                string json = JsonConvert.SerializeObject(postModel);
                json = json.Replace("_event", "event");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //var result = await client.PostAsync(url, content).Result.Content.ReadAsStringAsync();

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff");

                using SqlConnection db = new SqlConnection(ConString);
                var res = db.QueryAsync($@"insert into VerificationReverseZags(FamilyId,SentJson,RequestTime)
                                        values({get.id},'{json}','{dateTime}')").Result;


                return "dfgrtfh";
            }
            catch
            {
                return String.Empty;
            }
        }

        public void ResposeResult(ResponseModel model)
        {
            try
            {
                // not edited
                var stateNull = model?.applicationStates?.All(x => x.state == null);
                // rejected
                var stateEqualsTwo = model?.applicationStates?.Any(x => x.state == 2);
                // in proccess
                var stateEqualsZero = model?.applicationStates?.Any(x => x.state == 0);

                if (stateNull == true)
                {
                    _dbcontext.VerificationReverseZags.Where(x => x.FamilyId == model!.taskId).ToList().ForEach(x => x.Corrected = 1);
                }
                else if (stateEqualsTwo == true)
                {
                    _dbcontext.VerificationReverseZags.Where(x => x.FamilyId == model!.taskId).ToList().ForEach(x => x.Corrected = 2);
                }
                else if (stateEqualsTwo is false && stateEqualsZero is false)
                {
                    _dbcontext.VerificationReverseZags.Where(x => x.FamilyId == model!.taskId).ToList().ForEach(x => x.Corrected = 1);
                }
                _dbcontext.SaveChanges();

            }
            catch (Exception ex)
            {
            }

        }

    }





    //    public ResponseModel? ResponseClient(string id)
    //    {
    //        string url = "http://10.190.24.138:7074/family-traversal/rest-api/get-task-state/minfin/";

    //        HttpClient Client = new HttpClient();
    //        Client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
    //        Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Basic TWlORmlubjpGaW5MYUxhbkQ=");

    //        var result = Client.GetAsync(url + id).Result;

    //        var item = JsonConvert.DeserializeObject<ResponseModel>(result.ToString());

    //        return item;
    //    }
    //}
}
