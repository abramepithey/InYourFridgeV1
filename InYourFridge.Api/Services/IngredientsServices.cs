using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InYourFridge.Api.Contracts;
using InYourFridge.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InYourFridge.Api.Services
{
    public class IngredientsServices : IIngredientsServices
    {
        private readonly FridgeContext _context;

        public IngredientsServices(FridgeContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }
        
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
        {
            throw new System.NotImplementedException();
        }

        public async Task<ActionResult<Ingredient>> GetIngredient(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Order>>> GetOrdersOfIngredient(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IActionResult> PutIngredient(int id, Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ActionResult<Ingredient>> PostIngredient(Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IActionResult> DeleteIngredient(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}