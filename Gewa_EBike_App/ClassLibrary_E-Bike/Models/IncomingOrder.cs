using System;

namespace ClassLibraryEBike
{
    public class IncomingOrder : Order 
    {
        public DateTime DueDate { get; set; }
        public Company Customer { get; set; }

        public IncomingOrder(int id, PartialOrder[] partialOrders, DateTime dueDate, Company customer) : base(id, partialOrders)
        {
            DueDate = dueDate;
            Customer = customer;
        }
    }
}
