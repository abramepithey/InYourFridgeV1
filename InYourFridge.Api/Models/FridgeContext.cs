using Microsoft.EntityFrameworkCore;

namespace InYourFridge.Api.Models
{
    public class FridgeContext : DbContext
    {
        public FridgeContext(DbContextOptions<FridgeContext> options) : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}