using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities.Configurations;

internal class PickupPointConfiguration : IEntityTypeConfiguration<PickupPoint>
{
    public void Configure(EntityTypeBuilder<PickupPoint> builder)
    {
        builder
            .HasKey(pp => pp.Id);

        builder
            .Property(pp => pp.Id)
            .ValueGeneratedOnAdd();

        builder
            .HasOne(pp => pp.Employee)
            .WithOne(e => e.PickupPoint)
            .HasForeignKey<PickupPoint>(pp => pp.EmployeeId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
