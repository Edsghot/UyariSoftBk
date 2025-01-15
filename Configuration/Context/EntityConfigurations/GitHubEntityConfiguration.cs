using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Configuration.Context.EntityConfigurations;

public class GitHubEntityConfiguration : IEntityTypeConfiguration<GitHubEntity>
{
    public void Configure(EntityTypeBuilder<GitHubEntity> builder)
    {
        builder.HasKey(g => g.GitHubId);

        builder.Property(g => g.Url)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(g => g.ProductId)
            .IsRequired();
    }
}