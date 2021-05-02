using System.Collections.Generic;
using System.Threading.Tasks;
using InYourFridge.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace InYourFridge.Api.Contracts
{
    public interface IOrdersServices
    {
        public Task<ActionResult<IEnumerable<Order>>> GetOrders();
        public Task<ActionResult<Order>> GetOrder(int id);
        public Task<IActionResult> PutOrder(int id, Order order);
        public Task<ActionResult<Order>> PostOrder(Order order);
        public Task<IActionResult> DeleteOrder(int id);
    }
}