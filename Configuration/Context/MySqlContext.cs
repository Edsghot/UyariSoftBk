using Microsoft.EntityFrameworkCore;
using UyariSoftBk.Configuration.Context.EntityConfigurations;
using UyariSoftBk.Modules.Product.Domain.Entity;
using UyariSoftBk.Modules.Event.Domain.Entity;
using UyariSoftBk.Modules.Student.Domain.Entity;
using UyariSoftBk.Modules.Teacher.Domain.Entity;

namespace UyariSoftBk.Configuration.Context;

public class MySqlContext : DbContext
{
    public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
    {
    }
    
    public DbSet<ProductEntity> Attendances { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString =
            "Server=jhedgost.com;Database=dbjhfjuv_UyariSoft;User=dbjhfjuv_edsghot;Password=Repro321.;";

        optionsBuilder.UseMySql(
            connectionString,
            new MySqlServerVersion(new Version(8, 0, 21))
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AttendanceEntityConfiguration());
    }
}