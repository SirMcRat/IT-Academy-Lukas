using System.Collections.Generic;

namespace ClassLibraryEBike
{
    public abstract class Order : Entity
    {
        public List<PartialOrder> PartialOrders = new List<PartialOrder>();

        public Order() : base() { }        

        public abstract void CreatePartialOrder(Product product, int amount);
        public abstract void ClearPartialOrders();
    }
}
