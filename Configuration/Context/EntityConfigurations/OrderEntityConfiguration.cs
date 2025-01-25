using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Configuration.Context.EntityConfigurations;

public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
{
    public void Configure(EntityTypeBuilder<OrderEntity> builder)
    {
        builder.HasKey(o => o.OrderId);

        builder.Property(o => o.OrderDate)
            .IsRequired();

        builder.Property(o => o.UserId)
            .IsRequired();
        
        builder.Property(o => o.TotalAmount)
            .HasColumnType("decimal(18,2)");
        
    }
}