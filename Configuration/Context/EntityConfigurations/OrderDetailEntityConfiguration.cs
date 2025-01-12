using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Configuration.Context.EntityConfigurations;

public class OrderDetailEntityConfiguration : IEntityTypeConfiguration<OrderDetailEntity>
{
    public void Configure(EntityTypeBuilder<OrderDetailEntity> builder)
    {
        builder.HasKey(od => od.OrderDetailId);

        builder.Property(od => od.Quantity)
            .IsRequired();

        builder.Property(od => od.Price)
            .HasColumnType("decimal(18,2)");

        builder.HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId);

        builder.HasOne(od => od.Product)
            .WithMany()
            .HasForeignKey(od => od.ProductId);
    }
}