using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities.Configurations;

internal class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
           .HasKey(o => o.Id);

        builder
            .Property(o => o.Id)
            .ValueGeneratedOnAdd();

        builder
            .HasOne(o => o.Buyer)
            .WithOne(o => o.Order)
            .HasForeignKey<Order>(o => o.BuyerId)
            .OnDelete(DeleteBehavior.SetNull);

        builder
            .HasOne(o => o.PickupPoint)
            .WithOne(o => o.Order)
            .HasForeignKey<Order>(o => o.PickupPointId)
            .OnDelete(DeleteBehavior.SetNull);

        builder
            .HasMany(o => o.Products)
            .WithMany(p => p.Orders);
    }
}
