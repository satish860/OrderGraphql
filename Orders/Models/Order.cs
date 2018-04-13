using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Order
    {
        public Order(string name,string desciption
            ,DateTime createdDate
            ,int customerId,string id)
        {
            Name = name;
            Desciption = desciption;
            CreatedDate = createdDate;
            CustomerId = customerId;
            Id = id;
            status = OrderStatuses.CREATED;
        }

        public string Name { get; set; }
        public string Desciption { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public string Id { get; set; }
        public OrderStatuses status { get; set; }
    }

    [Flags]
    public enum OrderStatuses
    {
        CREATED = 2,
        PROCESSING = 4,
        COMPLETED = 8,
        CANCELLED = 16,
        CLOSED = 32
    }
}
