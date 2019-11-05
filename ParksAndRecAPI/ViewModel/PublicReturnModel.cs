using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ParksAndRecAPI.ViewModels
{
  public class PublicReturnModel
  {
    public string Park { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int ZipCode { get; set; }

    public double Acres { get; set; }

    public int YearFounded{get;set;}

  }
}