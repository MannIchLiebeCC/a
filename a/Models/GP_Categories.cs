using System.ComponentModel.DataAnnotations;

namespace a.Models
{
    public class GP_Categories
    {
        [Key] public Int64 GP_Num { get; set; }
        public string GP_App4sch { get; set; }
        public string GP_Name { get; set; }
        public string GP_Address { get; set; }
        public DateOnly GP_Date { get; set; }
        public DateOnly GP_Classification { get; set; }
        public string GP_Department { get; set; }
        public string GP_Course { get; set; }
        public string GP_Year { get; set; }
        public string GP_PlateNumber { get; set; }
        public DateOnly GP_DateExpiration { get; set; }
        public string GP_Vehicle { get; set; }
        public string GP_Marker { get; set; }
        public string GP_Color { get; set; }
        public byte[] GP_LoadnRegis { get; set; }
        public string GP_Approval1 { get; set; }
        public string GP_Approval2 { get; set; }
        public string GP_Approval3 { get; set; }

        public IFormFile GPImageFile { get; set; }

    }
}
