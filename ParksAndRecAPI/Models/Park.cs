using System.ComponentModel.DataAnnotations;
namespace ParksAndRecAPI.Models {
    public class Park {
        public int ParkId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public double Acres { get; set; }
        [Range(1872,2019, ErrorMessage="The year founded must be after or equal to The Yellowstone Act of 1872")]
        public int YearFounded { get; set; }
        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}