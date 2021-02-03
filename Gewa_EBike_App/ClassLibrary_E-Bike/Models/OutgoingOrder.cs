using System;

namespace ClassLibraryEBike
{
    public class OutgoingOrder : Order
    {
        public DateTime OrderDate { get; set; }
        public Company Supplier { get; set; }

        public OutgoingOrder(int id, PartialOrder[] partialOrders, DateTime orderDate, Company supplier) : base(id, partialOrders)
        {
            OrderDate = orderDate;
            Supplier = supplier;
        }
    }
}
