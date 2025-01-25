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
        builder.Property(od => od.OrderId)
            .IsRequired();
        builder.Property(od => od.ProductId)
            .IsRequired();
        builder.Property(od => od.Price)
            .HasColumnType("decimal(18,2)");

    
    }
}