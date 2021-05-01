using Microsoft.EntityFrameworkCore;

namespace InYourFridge.Api.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Salt" },
                new Ingredient { Id = 2, Name = "Pepper" },
                new Ingredient { Id = 3, Name = "Milk" },
                new Ingredient { Id = 4, Name = "Eggs" },
                new Ingredient { Id = 5, Name = "Bread" });

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, IngredientId = 1, Quantity = 0 },
                new Order { Id = 2, IngredientId = 1, Quantity = 4 },
                new Order { Id = 3, IngredientId = 2, Quantity = 3 },
                new Order { Id = 4, IngredientId = 3, Quantity = 0 },
                new Order { Id = 5, IngredientId = 3, Quantity = 1 },
                new Order { Id = 6, IngredientId = 4, Quantity = 12 },
                new Order { Id = 7, IngredientId = 5, Quantity = 0 },
                new Order { Id = 8, IngredientId = 5, Quantity = 1 });
        }
    }
}