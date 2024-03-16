    using DAL.Entities.Configurations;
using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities.Contexts;

public class MarketplaceDbContext : DbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Seller> Seller { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<PickupPoint> PickupPoint { get; set; }
    public DbSet<Buyer> Buyer { get; set; }
    public DbSet<Order> Order { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=localhost;
            Database=Marketplace;
            TrustServerCertificate=True;
            Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new SellerConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new PickupPointConfiguration());
        modelBuilder.ApplyConfiguration(new BuyerConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
    }
}
