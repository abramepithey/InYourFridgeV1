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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasMany(i => i.Orders).WithOne(o => o.Ingredient)
                .HasForeignKey(o => o.IngredientId);
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}