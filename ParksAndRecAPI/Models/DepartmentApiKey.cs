using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ParksAndRecAPI.Models {
    public class ApiKey {
        public int ApiKeyId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public string EmployeeFirst {get;set;}
        [Required]
        public string EmployeeLast {get;set;}
        [Required]
        public string APIKey { get; set; }
        
    }
}