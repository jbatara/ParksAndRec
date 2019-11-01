using Microsoft.EntityFrameworkCore;

namespace ParksAndRecAPI.Models {
    public class ParksAndRecDbContext : DbContext {
        public ParksAndRecDbContext (DbContextOptions<ParksAndRecDbContext> options) : base (options) { }

        public DbSet<Park> Parks { get; set; }
        public DbSet<Department> Departments { get; set; }
        // protected override void OnModelCreating (ModelBuilder builder) {
        //     builder.Entity<Park> ()
        //         .HasData (
        //             new Word { WordId = 1, Name = "moist", Rating = 2, RatingCount = 1 },
        //             new Word { WordId = 2, Name = "damp", Rating = 1, RatingCount = 1 },
        //             new Word { WordId = 3, Name = "hug", Rating = 4, RatingCount = 1 },
        //             new Word { WordId = 4, Name = "burnt", Rating = 5, RatingCount = 1 },
        //             new Word { WordId = 5, Name = "vomit", Rating = 1, RatingCount = 1 }
        //         );
        // }

    }
}