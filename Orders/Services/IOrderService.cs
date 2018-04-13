using Orders.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orders.Services
{
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string Id);

        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}