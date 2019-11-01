namespace ParksAndRecAPI.Models
{
    public class Park
    {
        public int ParkId {get;set;}
        public string Name {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public int ZipCode {get;set;}
        public int DepartmentId {get;set;}
    }
}