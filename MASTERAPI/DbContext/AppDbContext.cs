using MASTERAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace MASTERAPI.Data
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(a => a.Category)
                .HasForeignKey(c => c.CategoryId);
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 4);

            base.OnModelCreating(modelBuilder);

        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
