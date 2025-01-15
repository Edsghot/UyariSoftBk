using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Configuration.Context.EntityConfigurations;

public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.HasKey(p => p.ProductId);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Description)
            .HasMaxLength(500);

        builder.Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.Stock)
            .IsRequired();

        builder.Property(p => p.UploadDate)
            .IsRequired();

        builder.Property(p => p.ModificationDate)
            .IsRequired();

        builder.Property(p => p.Cover)
            .HasMaxLength(200);

        builder.Property(p => p.Icon)
            .HasMaxLength(200);

        builder.Property(p => p.IdImages)
            .IsRequired();

        builder.Property(p => p.IdGitHub)
            .IsRequired();
        builder.Property(p => p.Discount)
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.Rating)
            .IsRequired();

        builder.Property(p => p.NumberOfReviews)
            .IsRequired();

        builder.Property(p => p.InstallationIntructions)
            .HasMaxLength(500);

        builder.Property(p => p.Version)
            .HasMaxLength(50);

        builder.Property(p => p.Developer)
            .HasMaxLength(100);

        builder.Property(p => p.WebSite)
            .HasMaxLength(200);

        builder.HasMany(p => p.ProductCategories)
            .WithOne(pc => pc.Product)
            .HasForeignKey(pc => pc.ProductId);
    }
}