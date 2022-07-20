namespace ZagsReverseConnection.API.Models
{
    public class PostModel
    {
        public long id { get; set; }
        public int result_code { get; set; }
        public object result_message { get; set; }
        public string direction { get; set; }
        public string phone { get; set; }
        public object task_id { get; set; }
        public object user_id { get; set; }
        public Details[] details { get; set; }
    }
}


public class Details
{
    public long? id { get; set; }
    public string family_member { get; set; }
    public string pinfl { get; set; }
    public string surname { get; set; }
    public string name { get; set; }
    public string middlename { get; set; }
    public string birthday { get; set; }
    public string gender { get; set; }
    public string _event { get; set; }
    public object active_reason { get; set; }
    public int branch { get; set; }
    public string certSeries { get; set; }
    public string certNumber { get; set; }
    public string date_reg { get; set; }
    public object active { get; set; }
    public string action { get; set; }
    public object stages { get; set; }
    public int? member_num { get; set; }
    public object person_id { get; set; }
    public object return_id { get; set; }
    public string return_action_message { get; set; }
    public string return_content_message { get; set; }
}
