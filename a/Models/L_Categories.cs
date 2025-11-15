using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace a.Models
{
    public partial class L_Categories
    {
        [Key] public Int64 L_Num { get; set; }
        public string L_StuName { get; set; }

        public Int64 L_StuID { get; set; }

        public string LockerCode { get; set; }
        public string L_Semester { get; set; }
        public int L_ContactNumber { get; set; }

        // Image stored as byte[]
        public byte[] L_LoadnRegis { get; set; }

        public string L_Approval { get; set; } = "Pending";

        // Not saved to database (used only for upload)
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
