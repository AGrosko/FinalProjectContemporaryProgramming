﻿// <auto-generated />
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations.FavTeam
{
    [DbContext(typeof(FavTeamContext))]
    partial class FavTeamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.Models.FavTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("basketball")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("collegefootball")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("football")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavTeams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            basketball = "Heat",
                            collegefootball = "BearCats",
                            football = "Colts",
                            name = "Andrew Grosko"
                        },
                        new
                        {
                            Id = 2,
                            basketball = "celtics",
                            collegefootball = "crimson tide",
                            football = "49ers",
                            name = "Liam Brian"
                        },
                        new
                        {
                            Id = 3,
                            basketball = "celtics",
                            collegefootball = "crimson tide",
                            football = "49ers",
                            name = "Ireland Castle"
                        },
                        new
                        {
                            Id = 4,
                            basketball = "celtics",
                            collegefootball = "crimson tide",
                            football = "49ers",
                            name = "Elizabeth Stolle"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
