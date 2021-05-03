using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using InYourFridge.Api.Models;

namespace InYourFridge.Blazor.Services
{
    public class IngredientServices : IIngredientServices
    {
        public async Task<IEnumerable<Ingredient>> GetIngredients()
        {
            throw new System.NotImplementedException();
        }
    }
}