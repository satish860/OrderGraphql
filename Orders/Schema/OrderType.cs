using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using Orders.Models;
using Orders.Services;

namespace Orders.Schema
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType(ICustomerService customerService)
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Desciption);
            Field<CustomerType>("customers"
                , resolve: context => customerService.GetCustomerByIdAsync(context.Source.CustomerId));
            Field(c => c.CreatedDate);
            Field<OrderStatusesEnum>("Status", resolve: context => context.Source.status);

        }
    }
}
