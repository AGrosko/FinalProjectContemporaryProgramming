﻿// <auto-generated />
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations.Grades
{
    [DbContext(typeof(GradesContext))]
    partial class GradesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.Models.Grades", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("englishGrade")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("mathGrade")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("scienceGrade")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ID");

                    b.ToTable("Gradess");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Andrew Grosko",
                            englishGrade = "A",
                            mathGrade = "B",
                            scienceGrade = "A"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Liam Brian",
                            englishGrade = "B",
                            mathGrade = "A",
                            scienceGrade = "A"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Ireland Castle",
                            englishGrade = "A",
                            mathGrade = "B",
                            scienceGrade = "A"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Elizabeth Stolle",
                            englishGrade = "A",
                            mathGrade = "B",
                            scienceGrade = "A"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
