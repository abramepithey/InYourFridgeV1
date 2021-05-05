using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using InYourFridge.Blazor.Models;

namespace InYourFridge.Blazor.Services
{
    public class IngredientServices : IIngredientServices
    {
        private readonly HttpClient _httpClient;

        public IngredientServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IEnumerable<Ingredient>> GetIngredients()
        {
            return await _httpClient.GetFromJsonAsync<List<Ingredient>>("ingredients");
        }
    }
}