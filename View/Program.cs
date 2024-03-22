using DAL.Entities.Contexts;
using DAL.Entities.Models;
using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MarketplaceDbContext>();
builder.Services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();

var app = builder.Build();
app.MapControllers();

app.Run();
