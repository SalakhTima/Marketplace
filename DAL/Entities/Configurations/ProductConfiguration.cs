using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasKey(p => p.Id);

        builder
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();

        builder
            .HasMany(p => p.Sellers)
            .WithMany(s => s.Products);

        builder
            .HasMany(p => p.Orders)
            .WithMany(o => o.Products);
    }
}