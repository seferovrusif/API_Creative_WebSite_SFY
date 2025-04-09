using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SFY.Core.Entities;

namespace SFY.DAL.Configurations
{
    public class BagConfiguration : IEntityTypeConfiguration<Bag>
    {
        public void Configure(EntityTypeBuilder<Bag> builder)
        {
            builder.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(32);

            builder.HasOne(a => a.AppUser)
                .WithMany(b => b.Bags)
                .HasForeignKey(a => a.AppUserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(a => a.Color)
                .WithMany(b => b.Bags)
                .HasForeignKey(a => a.ColorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Handle_Color)
                .WithMany(b => b.Bag_Handles)
                .HasForeignKey(a => a.Handle_ColorId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(a => a.Material)
                .WithMany(b => b.Bags)
                .HasForeignKey(a => a.MaterialId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Handle_Material)
               .WithMany(b => b.Bag_Handles)
               .HasForeignKey(a => a.Handle_MaterialId)
               .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(a => a.Size)
               .WithMany(b => b.Bags)
               .HasForeignKey(a => a.SizeId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Handle_Size)
               .WithMany(b => b.Bag_Handles)
               .HasForeignKey(a => a.Handle_SizeId)
               .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
