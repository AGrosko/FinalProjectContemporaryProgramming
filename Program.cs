using FinalProject.Controllers;
using FinalProject.Data;
using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Basic Info
builder.Services.AddControllers();
builder.Services.AddDbContext<FinalProject.Data.BasicInfoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BasicInfoContext")));

builder.Services.AddScoped<IBasicInfoContextDOA, BasicInfoContextDOA>();

// Favorite Teams
builder.Services.AddControllers();
builder.Services.AddDbContext<FinalProject.Data.FavTeamContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FavTeamContext")));

builder.Services.AddScoped<IFavTeamContextDOA, FavTeamContextDOA>();

// Grades
builder.Services.AddControllers();
builder.Services.AddDbContext<FinalProject.Data.GradesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GradesContext")));

builder.Services.AddScoped<IGradesContextDOA, GradesContextDOA>();

//FavSong
builder.Services.AddControllers();
builder.Services.AddDbContext<FinalProject.Data.FavSongContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FavSongContext")));

builder.Services.AddScoped<IFavSongsContextDOA, FavSongsContextDOA>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
