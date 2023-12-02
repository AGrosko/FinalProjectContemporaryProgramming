using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations.FavTeam
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    football = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    basketball = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    collegefootball = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavTeams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavTeams",
                columns: new[] { "Id", "basketball", "collegefootball", "football", "name" },
                values: new object[,]
                {
                    { 1, "Heat", "BearCats", "Colts", "Andrew Grosko" },
                    { 2, "celtics", "crimson tide", "49ers", "Liam Brian" },
                    { 3, "celtics", "crimson tide", "49ers", "Ireland Castle" },
                    { 4, "celtics", "crimson tide", "49ers", "Elizabeth Stolle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavTeams");
        }
    }
}
