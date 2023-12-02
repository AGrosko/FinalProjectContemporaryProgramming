using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class FavTeamContext : DbContext
    {
        public FavTeamContext(DbContextOptions<FavTeamContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.FavTeam>().HasData(new Models.FavTeam
            { Id = 1, football = "Colts", basketball = "Heat", collegefootball = "BearCats", name = "Andrew Grosko" },
            new Models.FavTeam { Id = 2, football = "49ers", basketball = "celtics", collegefootball = "crimson tide", name = "Liam Brian" },
           new Models.FavTeam { Id = 3, football = "49ers", basketball = "celtics", collegefootball = "crimson tide", name = "Ireland Castle" },
            new Models.FavTeam { Id = 4, football = "49ers", basketball = "celtics", collegefootball = "crimson tide", name = "Elizabeth Stolle" }
            );
        }

        public DbSet<Models.FavTeam> FavTeams { get; set; }
    }
}
