namespace ClassLibraryEBike
{
    public class PartialOrder : Entity
    {      
        public Product Product { get; set; }
        public int Amount { get; set; }

        public PartialOrder(Product product, int amount) : base()
        {
            Product = product;
            Amount = amount;
        }

    }
}
