using Orders.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orders.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);

        Task<Customer> GetCustomerByIdAsync(int id);

        Task<IEnumerable<Customer>> GetCustomers();
    }
}