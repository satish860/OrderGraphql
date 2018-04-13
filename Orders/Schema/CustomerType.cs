using Orders.Models;
using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;

namespace Orders.Schema
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field<int>(c => c.Id);
            Field<string>(c => c.Name);
        }
    }
}
