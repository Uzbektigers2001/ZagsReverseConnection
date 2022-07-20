using System.ComponentModel.DataAnnotations;

namespace ZagsReverseConnection.API.Models
{
    public class VerificationReverseZags
    {
        [Key]
        public long? VerificationId { get; set; }
        public string? ApplicantPinfl { get; set; }
        public long? FamilyId { get; set; }
        public long? SelfId { get; set; }
        public string? SentJson { get; set; }
        public DateTime? RequestTime { get; set; }
        public int? Corrected { get; set; }
        public int? Applied { get; set; }
    }
}
