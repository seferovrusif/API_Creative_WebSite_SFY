using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SFY.Core.Entities;

namespace SFY.DAL.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(a => a.Fullname)
                .IsRequired()
                .HasMaxLength(32);
            builder.Property(a => a.BirthDate)
               .IsRequired()
               .HasColumnType("date");
        }
    }
}
