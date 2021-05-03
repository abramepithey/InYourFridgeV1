using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InYourFridge.Api.Models;
using InYourFridge.Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace InYourFridge.Blazor.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IIngredientServices IngredientServices { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}