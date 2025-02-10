using Microsoft.EntityFrameworkCore;
using UyariSoftBk.Configuration.Context.EntityConfigurations;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Configuration.Context;

public class MySqlContext : DbContext
{
    public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
    {
    }
    
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<OrderDetailEntity> OrderDetails { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<ProductImageEntity> ProductImages { get; set; }
    public DbSet<UserEntity> Users  {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString =
            "Server=jhedgost.com;Database=dbjhfjuv_UyariSoft;User=dbjhfjuv_edsghot;Password=Repro321.;";
       // var connectionString = "Server=jhedgost.com;Database=dbjhfjuv_UyariSoft;User=dbjhfjuv_edsghot;Password=Repro321.;"

       optionsBuilder.UseMySql(
           connectionString,
           new MySqlServerVersion(new Version(8, 0, 21)),
           options => options.EnableRetryOnFailure()
       );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new OrderDetailEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        
        modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductImageEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new GitHubEntityConfiguration());
    }
}