using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations.Grades
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gradess",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mathGrade = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    englishGrade = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    scienceGrade = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradess", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Gradess",
                columns: new[] { "ID", "Name", "englishGrade", "mathGrade", "scienceGrade" },
                values: new object[,]
                {
                    { 1, "Andrew Grosko", "A", "B", "A" },
                    { 2, "Liam Brian", "B", "A", "A" },
                    { 3, "Ireland Castle", "A", "B", "A" },
                    { 4, "Elizabeth Stolle", "A", "B", "A" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gradess");
        }
    }
}
