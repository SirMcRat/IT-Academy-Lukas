using System;

namespace ClassLibraryEBike
{
    public class OutgoingOrder:Order
    {
        public DateTime OrderDate;
        public Company Supplier;

        public OutgoingOrder(int iD, PartialOrder[] partialOrders, DateTime orderDate, Company supplier): base(iD, partialOrders)
        {
            OrderDate = orderDate;
            Supplier = supplier;
        }
    }
}
