using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities.Contexts;

public class MarketplaceDbContext : DbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Seller> Seller { get; set; }
    public DbSet<SellersProducts> SellersProducts { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<PickupPoint> PickupPoint { get; set; }
    public DbSet<Buyer> Buyer { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<OrdersProducts> OrdersProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            @"Server=localhost;
            Database=Marketplace;
            TrustServerCertificate=True;
            Trusted_Connection=True;");
}
