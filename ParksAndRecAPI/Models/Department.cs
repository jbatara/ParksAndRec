using System.Collections.Generic;
namespace ParksAndRecAPI.Models
{
    public class Department
    {
        public Department()
        {
            this.Parks = new HashSet<Park>();
        }
        public int DepartmentId {get;set;}
        public string DepartmentHead_FirstName {get;set;}
        public string DepartmentHead_LasetName {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        
        public ICollection<Park> Parks {get;set;}
    }
}