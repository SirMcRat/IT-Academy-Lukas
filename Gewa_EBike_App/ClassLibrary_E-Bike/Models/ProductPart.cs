namespace ClassLibraryEBike
{
    public class ProductPart : Entity
    {
        public SinglePart Part { get; set; }
        public int Amount { get; set; }

        public ProductPart(SinglePart part, int amount) : base()
        {
            Part = part;
            Amount = amount;
        }
    }
}
