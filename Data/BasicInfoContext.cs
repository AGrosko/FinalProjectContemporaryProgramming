using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class BasicInfoContext : DbContext
    {

        public BasicInfoContext(DbContextOptions<BasicInfoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.BasicInfo>().HasData(new Models.BasicInfo
            { id = 1, birthDate = new DateTime(2003, 06, 04), name = "Andrew Grosko", collegeProgram = "IT", yearInProgram = "Junior" },
            new Models.BasicInfo { id = 2, birthDate = new DateTime(2002, 07, 20), name = "Liam Brian", collegeProgram = "Mechanical Engineering", yearInProgram = "Senior" },
            new Models.BasicInfo { id = 3, birthDate = new DateTime(2003, 08, 13), name = "Ireland Castle", collegeProgram = "Media Production", yearInProgram = "Junior" },
            new Models.BasicInfo { id = 4, birthDate = new DateTime(2002, 05, 04), name = "Elizabeth Stolle", collegeProgram = "Health Sciences", yearInProgram = "Senior" }
            );
        }

        public DbSet<Models.BasicInfo> BasicInfos { get; set; }

    }
}
