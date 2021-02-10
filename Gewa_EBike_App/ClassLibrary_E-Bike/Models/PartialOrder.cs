namespace ClassLibraryEBike
{
    public class PartialOrder : Entity
    {      
        public InOut IncomingOutgoing { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        public PartialOrder(int id, InOut incomingOutgoing, Product product, int amount) : base(id)
        {
            IncomingOutgoing = incomingOutgoing;
            Product = product;
            Amount = amount;
        }
    }
}
