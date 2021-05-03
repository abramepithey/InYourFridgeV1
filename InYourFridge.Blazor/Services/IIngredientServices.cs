using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using InYourFridge.Api.Models;

namespace InYourFridge.Blazor.Services
{
    public interface IIngredientServices
    {
        Task<IEnumerable<Ingredient>> GetIngredients();
    }
}