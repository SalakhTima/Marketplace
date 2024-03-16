using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities.Configurations;

internal class SellerConfiguration : IEntityTypeConfiguration<Seller>
{
    public void Configure(EntityTypeBuilder<Seller> builder)
    {
        builder
             .HasKey(s => s.Id);

        builder
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();

        builder
            .HasMany(s => s.Products)
            .WithMany(p => p.Sellers);
    }
}