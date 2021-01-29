using System;

namespace ClassLibraryEBike
{
    public class IncomingOrder:Order 
    {
        public DateTime DueDate { set; get; }
        public Company Customer { set; get; }

        public IncomingOrder(int iD, PartialOrder[] partialOrders, DateTime dueDate, Company customer):base(iD, partialOrders)
        {
            DueDate = dueDate;
            Customer = customer;
        }
    }
}
