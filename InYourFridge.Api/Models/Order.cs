using System;
using System.Text.Json.Serialization;

namespace InYourFridge.Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        [JsonIgnore]
        public virtual Ingredient Ingredient { get; set; }
        public int Quantity { get; set; }
        public bool IsActive => (Quantity > 0);
    }
}