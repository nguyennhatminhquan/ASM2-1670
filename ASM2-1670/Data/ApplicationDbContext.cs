using ASM2_1670.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASM2_1670.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Listing> Listings { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet <Application> Applications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId = 1, CategoryName = "Housemaid", CategoryDescription = "Work Hard" },
                 new Category { CategoryId = 2, CategoryName = "Cleaner", CategoryDescription = "Work Hard" },
                 new Category { CategoryId = 3, CategoryName = "Worker", CategoryDescription = "Work Hard" }
                );
            modelBuilder.Entity<Listing>().HasData(
                new Listing { JobId = 1, JobTitle = "CleanHouse", JobDescription = "Clean 2 House", ApplicationDeadline = new DateTime(2024, 01, 01), OtherDetails = "012345678", CategoryId = 1 },
                new Listing { JobId = 2, JobTitle = "CleanHouse", JobDescription = "1 month", ApplicationDeadline = new DateTime(2024, 01, 01), OtherDetails = "01876542", CategoryId = 2 }
                );
            modelBuilder.Entity<Application>().HasData(
                new Application { ApplicationId = 1, CoverLetter = "Hello", CV = null, ApplicationStatus = "Not yet", JobId = 1 },
                new Application { ApplicationId = 2, CoverLetter = "Hello", CV = null, ApplicationStatus = "Not yet", JobId = 2 }
                );
        }

    }
}
