using System.Collections.Generic;

namespace InYourFridge.Api.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}