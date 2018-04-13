using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orders.Models;
using System.Linq;

namespace Orders.Services
{
    public class CustomerService : ICustomerService
    {
        private IList<Customer> _customers;
        public CustomerService()
        {
            _customers = new List<Customer>();
            _customers.Add(new Customer(1, "KinetEco"));
            _customers.Add(new Customer(2, "Pixelford Photography"));
            _customers.Add(new Customer(3, "Topsy Turvy"));
            _customers.Add(new Customer(4, "Leaf & Mortar"));
        }

        public Customer GetCustomerById(int id)
        {
            return GetCustomerByIdAsync(id).Result;
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
           return Task.FromResult(_customers.Single(p => p.Id == id));
        }

        public Task<IEnumerable<Customer>> GetCustomers()
        {
           return Task.FromResult(_customers.AsEnumerable());
        }
    }
}
