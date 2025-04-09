using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SFY.Core.Entities;

namespace SFY.DAL.Configurations
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(64);
        }
    }
}
