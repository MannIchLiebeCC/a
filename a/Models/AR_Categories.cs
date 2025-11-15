using System.ComponentModel.DataAnnotations;

namespace a.Models
{
    public class AR_Categories
    {
        [Key] public Int64 AR_ReserveNum { get; set; }
        public string AR_NameOrg { get; set; }
        public string AR_ActivityTitle { get; set; }
        public string AR_Venue { get; set; }
        public int AR_DateSet { get; set; }
        public DateOnly AR_DateNeeded { get; set; }
        public TimeOnly AR_TimeFrom { get; set; }
        public TimeOnly AR_TimeTo { get; set; }
        public string AR_Participants { get; set; }
        public string AR_Speaker { get; set; }
        public string AR_PurposeObj { get; set; }
        public string AR_EquipF { get; set; }
        public string AR_NatureAct { get; set; }
        public string AR_SourceFund { get; set; }
        public string AR_Approval1 { get; set; } = "Pending";
        public string AR_Approval2 { get; set; } = "Pending";
        public string AR_Approval3 { get; set; } = "Pending";
        public string AR_Approval4 { get; set; } = "Pending";
        public string AR_Approval5 { get; set; } = "Pending";
    }
}
