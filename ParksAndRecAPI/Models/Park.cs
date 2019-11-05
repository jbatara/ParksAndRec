using System.ComponentModel.DataAnnotations;
using ParksAndRecAPI.ViewModels;
namespace ParksAndRecAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int ZipCode { get; set; }

    public double Acres { get; set; }

    [Range(1872, 2019, ErrorMessage = "The year founded must be after or equal to The Yellowstone Act of 1872")]
    public int YearFounded { get; set; }

    [Required]
    public int DepartmentId { get; set; }

    public Department Department { get; set; }

    public bool Equals(Park p)
    {
      if ((p.ParkId == ParkId) && (p.Name == Name) && (p.DepartmentId == DepartmentId))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public PublicReturnModel ConvertToPublicViewModel()
    {
      PublicReturnModel output;
      if (this == null)
      {
        output = new PublicReturnModel
        {
          Name = "No Parks Found",
          Address = null,
          City = null,
          ZipCode = 0,
          Acres = 0,
          YearFounded = 0
        };
      }
      else
      {
        output = new PublicReturnModel
        {
          Name = this.Name,
          Address = this.Address,
          City = this.City,
          ZipCode = this.ZipCode,
          Acres = this.Acres,
          YearFounded = this.YearFounded
        };
      }
      return output;
    }
  }
}