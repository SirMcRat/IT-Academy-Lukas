namespace ClassLibraryEBike
{

    public class PartialOrder : Entity
    {
        

        public enum InOut
        {
            Incoming, Outgoing
        }
        public InOut IncomingOutgoing { set; get; }
        public Product Product { set; get; }
        public int Amount { set; get; }

        public PartialOrder(int iD, InOut incomingOutgoing, Product product, int amount):base(iD)
        {
            IncomingOutgoing = incomingOutgoing;
            Product = product;
            Amount = amount;
        }
    }
}
