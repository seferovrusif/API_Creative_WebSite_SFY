using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SFY.Core.Entities;

namespace SFY.DAL.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(a => a.HexCode)
                .IsRequired()
                .HasMaxLength(16);  
        }
    }
}
