using System;
using System.Collections.Generic;
using System.Text;
using GraphQL;
using GraphQL.Types;

namespace Orders.Schema
{
    public class OrdersSchema : GraphQL.Types.Schema
    {
        public OrdersSchema(OrdersQuery query,IDependencyResolver dependencyResolver)
        {
            Query = query;
            DependencyResolver = dependencyResolver;
        }
    }
}
