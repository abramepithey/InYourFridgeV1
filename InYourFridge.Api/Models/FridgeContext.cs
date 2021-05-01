using Microsoft.EntityFrameworkCore;

namespace InYourFridge.Api.Models
{
    public class FridgeContext : DbContext
    {
        public FridgeContext(DbContextOptions<FridgeContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOne(i => i.Ingredient).WithMany(o => o.Orders)
                .HasForeignKey(o => o.IngredientId);
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}