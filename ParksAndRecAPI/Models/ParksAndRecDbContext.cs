using Microsoft.EntityFrameworkCore;

namespace ParksAndRecAPI.Models
{
  public class ParksAndRecDbContext : DbContext
  {
    public ParksAndRecDbContext(DbContextOptions<ParksAndRecDbContext> options) : base(options) { }

    public DbSet<Park> Parks { get; set; }
    public DbSet<Department> Departments { get; set; }

    public DbSet<ApiKey> ApiKeys { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, Name = "Pwnee Commons", YearFounded = 1986, DepartmentId = 2 },
              new Park { ParkId = 2, Name = "Harvey James Park", DepartmentId = 2 },
              new Park { ParkId = 3, Name = "Lafayette Park", DepartmentId = 2 },
              new Park { ParkId = 4, Name = "Eagleton Park", DepartmentId = 3 },
              new Park { ParkId = 5, Name = "Maplewood Park", DepartmentId = 2 },
              new Park { ParkId = 6, Name = "North Pawnee Recreation Center", DepartmentId = 2 },
              new Park { ParkId = 7, Name = "Wamapokestone Park", DepartmentId = 2 },
              new Park { ParkId = 8, Name = "Tucker Park", DepartmentId = 2 },
              new Park { ParkId = 9, Name = "Pawnee Park: Smallest Park in Indiana", DepartmentId = 2 },
              new Park { ParkId = 10, Name = "Slippery Elm Park", DepartmentId = 2 },
              new Park { ParkId = 11, Name = "Ramsett Park", DepartmentId = 2 }
          );
      builder.Entity<Department>()
          .HasData(
              new Department { DepartmentId = 1, DepartmentHead_LasetName = "Stratton", DepartmentHead_FirstName = "Kristine", DepartmentName = "National Recreation and Park Association" },
              new Department { DepartmentId = 2, DepartmentHead_FirstName = "Ron", DepartmentHead_LasetName = "Swanson", DepartmentName = "Pawnee Parks and Recreation Department" },
              new Department { DepartmentId = 3, DepartmentHead_FirstName = "First", DepartmentHead_LasetName = "Last", DepartmentName = "Eagleton Parks and Recreation Department" }
          );
    }

  }
}