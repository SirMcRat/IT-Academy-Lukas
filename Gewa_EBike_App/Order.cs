namespace ClassLibraryEBike
{
    public class Order:Entity
    {
        public PartialOrder[] PartialOrders;

        public Order(int iD, PartialOrder[] partialOrders):base(iD)
        {
            PartialOrders = partialOrders;
        }
    }
}
