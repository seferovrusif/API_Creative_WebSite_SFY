using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SFY.Core.Entities;
using SFY.Core.Entities.Common;
using System.Reflection;

namespace SFY.DAL.Contexts
{
    public class SFYTestContext : IdentityDbContext
    {
        public SFYTestContext(DbContextOptions opt) : base(opt)
        {
        }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Material> Materials { get; set; }  
        public DbSet<Color> Colors { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedTime = DateTime.UtcNow;
                    entry.Entity.UpdatedTime = DateTime.UtcNow;
                    entry.Entity.IsDeleted= false;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedTime = DateTime.UtcNow;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //    modelBuilder.Entity<IdentityUser>().Ignore(b => b.PhoneNumber)
        //.Ignore(b => b.PhoneNumberConfirmed);
            base.OnModelCreating(modelBuilder);
        }
    }
}
