using UyariSoftBk.Modules.Product.Domain.Entity;
using UyariSoftBk.Modules.Teacher.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UyariSoftBk.Configuration.Context.EntityConfigurations;

public class AttendanceEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
{
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(a => a.IdAttendance);

            builder.Property(a => a.Date);


            builder.Property(a => a.IsPresent);

            builder.HasOne(a => a.Teacher)
                .WithMany(t => t.Attendances)
                .HasForeignKey(a => a.TeacherId)
                .OnDelete(DeleteBehavior.Cascade).IsRequired(false);
            
            builder.HasOne(a => a.Student)
                .WithMany(s => s.Attendances)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Cascade).IsRequired(false);

            builder.HasOne(a => a.Event)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EventId)
                .OnDelete(DeleteBehavior.Cascade).IsRequired(false);
            
            builder.HasOne(a => a.Guest)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.GuestId)
                .OnDelete(DeleteBehavior.Cascade).IsRequired(false);
        }
    
}