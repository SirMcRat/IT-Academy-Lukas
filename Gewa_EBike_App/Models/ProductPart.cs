namespace ClassLibraryEBike
{
    public class ProductPart : Entity
    {
        public SinglePart Part { get; set; }
        public int Amount { get; set; }

        public ProductPart(int id, SinglePart part, int amount) : base(id)
        {
            Part = part;
            Amount = amount;
        }
    }
}
