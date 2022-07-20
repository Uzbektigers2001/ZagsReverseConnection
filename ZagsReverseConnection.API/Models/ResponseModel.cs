
namespace ZagsReverseConnection.API.Models
{
    public class ResponseModel
    {
        public long taskId { get; set; }
        public Applicationstate[]? applicationStates { get; set; }
    }

    public class Applicationstate
    {
        public long? state { get; set; }
        public long traversalId { get; set; }
        public long traversalMemberId { get; set; }
        public long returnId { get; set; }
        public string? processingInfo { get; set; }
    }

    //public class ResponseModel
    //{
    //    public int taskId { get; set; }
    //    public Applicationstate[]? applicationStates { get; set; }
    //}

    //public class Applicationstate
    //{
    //    public int state { get; set; }
    //    public int traversalId { get; set; }
    //    public int traversalMemberId { get; set; }
    //    public string? processingInfo { get; set; }
    //}
}
