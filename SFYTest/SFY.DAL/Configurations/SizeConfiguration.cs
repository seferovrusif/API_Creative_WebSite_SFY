using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SFY.Core.Entities;

namespace SFY.DAL.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(16);
        }
    }
}
