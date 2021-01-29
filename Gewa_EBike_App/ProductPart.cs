namespace ClassLibraryEBike
{
    public class ProductPart:Entity
    {
        public SinglePart Part;
        public int Amount;

        public ProductPart(int iD, SinglePart part, int amount):base(iD)
        {
            Part = part;
            Amount = amount;
        }
    }
}
