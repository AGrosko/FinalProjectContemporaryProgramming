using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicInfos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    collegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInfos", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "BasicInfos",
                columns: new[] { "id", "birthDate", "collegeProgram", "name", "yearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Andrew Grosko", "Junior" },
                    { 2, new DateTime(2002, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mechanical Engineering", "Liam Brian", "Senior" },
                    { 3, new DateTime(2003, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Media Production", "Ireland Castle", "Junior" },
                    { 4, new DateTime(2002, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Health Sciences", "Elizabeth Stolle", "Senior" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicInfos");
        }
    }
}
