using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations.FavSong
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavSongs",
                columns: table => new
                {
                    iD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    song = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavSongs", x => x.iD);
                });

            migrationBuilder.InsertData(
                table: "FavSongs",
                columns: new[] { "iD", "artist", "genre", "name", "song" },
                values: new object[,]
                {
                    { 1, "Zach Bryan", "Country", "Andrew Grosko", "Whiskey Fever" },
                    { 2, "Morgan Wallen", "Country", "Liam Brian", "One Thing at a Time" },
                    { 3, "Wham", "Christmas", "Ireland Castle", "Last Christmas" },
                    { 4, "Morgan Wallen", "Country", "Elizabeth Stolle", "Last Night" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavSongs");
        }
    }
}
