using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;
using ZagsReverseConnection.API.Interfaces;
using ZagsReverseConnection.API.Models;

namespace ZagsReverseConnection.API.Services
{
    public class HomeService : IHomeService
    {
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
                get = family is not null? JsonConvert.DeserializeObject<GetFamilyModel>(family.ToString()) : new GetFamilyModel();

                PostModel? postModel = new PostModel();

                postModel = JsonConvert.DeserializeObject<PostModel>(JsonConvert.SerializeObject(get)
                    .Replace("pnfl", "pinfl")
                    .Replace("patronym", "middlename")
                    .Replace("birthDate", "birthday"));
                postModel.result_code = 1;


                var config = ConString;
                string url = "http://10.190.24.138:7074/family-traversal/rest-api/post-changed/minfin";
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Basic TWlORmlubjpGaW5MYUxhbkQ=");
                string json = JsonConvert.SerializeObject(postModel);
                json = json.Replace("_event", "event");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content).Result.Content.ReadAsStringAsync();

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff");

                SqlConnection db = new SqlConnection(config);
                var res = db.QueryAsync($@"insert into VerificationReverseZags(ApplicantPinfl,FamilyId,SelfId,SentJson,RequestTime)
                                        values({postModel.details.FirstOrDefault(x => x.family_member == "SELF").pinfl}
                                        , {postModel.id}
                                        , {postModel.details.FirstOrDefault(x => x.family_member == "SELF").id}, '{json}','{dateTime}')").Result;


                return result;
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}
