namespace ClassLibraryEBike
{
    public class Order : Entity
    {
        public PartialOrder[] PartialOrders { get; set; }

        public Order(int id, PartialOrder[] partialOrders) : base(id)
        { 
            PartialOrders = partialOrders;
        }
    }
}
