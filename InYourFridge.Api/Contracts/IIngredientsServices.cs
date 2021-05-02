using System.Collections.Generic;
using System.Threading.Tasks;
using InYourFridge.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace InYourFridge.Api.Contracts
{
    public interface IIngredientsServices
    {
        public Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients();
        public Task<ActionResult<Ingredient>> GetIngredient(int id);
        public Task<ActionResult<IEnumerable<Order>>> GetOrdersOfIngredient(int id);
        public Task<IActionResult> PutIngredient(int id, Ingredient ingredient);
        public Task<ActionResult<Ingredient>> PostIngredient(Ingredient ingredient);
        public Task<IActionResult> DeleteIngredient(int id);
    }
}