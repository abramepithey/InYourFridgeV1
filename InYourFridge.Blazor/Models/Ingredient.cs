using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InYourFridge.Blazor.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}