using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class FavSongContext:DbContext
    {

        public FavSongContext(DbContextOptions<FavSongContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.FavSong>().HasData(new Models.FavSong
            { iD = 1, artist = "Zach Bryan", name = "Andrew Grosko", genre = "Country", song = "Whiskey Fever" },
            new Models.FavSong { iD = 2, artist = "Morgan Wallen", name = "Liam Brian", genre = "Country", song = "One Thing at a Time" },
            new Models.FavSong { iD = 3, artist = "Wham", name = "Ireland Castle", genre = "Christmas",  song = "Last Christmas" },
            new Models.FavSong { iD = 4, artist = "Morgan Wallen", name = "Elizabeth Stolle", genre = "Country", song = "Last Night" }
            );
        }

        public DbSet<Models.FavSong> FavSongs { get; set; }

    }
}
