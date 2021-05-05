using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using InYourFridge.Blazor.Models;

namespace InYourFridge.Blazor.Services
{
    public interface IIngredientServices
    {
        Task<IEnumerable<Ingredient>> GetIngredients();
    }
}