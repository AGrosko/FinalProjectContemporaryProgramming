using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class GradesContext : DbContext
    {

        public GradesContext(DbContextOptions<GradesContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Grades>().HasData(new Models.Grades
            { ID = 1, englishGrade = 'A', Name = "Andrew Grosko", mathGrade = 'B', scienceGrade = 'A' },
            new Models.Grades { ID = 2, englishGrade = 'B', Name = "Liam Brian", mathGrade = 'A', scienceGrade = 'A' },
            new Models.Grades { ID = 3, englishGrade = 'A', Name = "Ireland Castle", mathGrade = 'B', scienceGrade = 'A' },
            new Models.Grades { ID = 4, englishGrade = 'A', Name = "Elizabeth Stolle", mathGrade = 'B', scienceGrade = 'A' }
            );
        }

        public DbSet<Models.Grades> Gradess { get; set; }

    }
}
