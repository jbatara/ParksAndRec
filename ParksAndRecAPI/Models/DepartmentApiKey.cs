using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ParksAndRecAPI.Models {
    public class DepartmentApiKey {
        public int DepartmentApiKeyId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public string APIKey { get; set; }

    }
}