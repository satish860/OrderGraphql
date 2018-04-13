using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Customer
    {
        public Customer(int Id,string name)
        {
            this.Id = Id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
    }
}
