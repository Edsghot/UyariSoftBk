using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Configuration.Context.EntityConfigurations;

public class ProductImageEntityConfiguration : IEntityTypeConfiguration<ProductImageEntity>
{
    public void Configure(EntityTypeBuilder<ProductImageEntity> builder)
    {
        builder.HasKey(pi => pi.ProductImageId);

        builder.Property(pi => pi.ImageUrl)
            .IsRequired()
            .HasMaxLength(800);

        builder.Property(pi => pi.ProductId)
            .IsRequired();
    }
}