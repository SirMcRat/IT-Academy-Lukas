namespace ClassLibraryEBike
{
    public class EndProduct : Product
    {
        public EndProductType Type { get; set; }
        public Company Customer { get; set; }
        public ProductPart[] Parts { get; set; }

        public EndProduct(string name, string serialNumber, EndProductType type, Company customer, ProductPart[] parts) : base(name, serialNumber)
        {
            Type = type;
            Customer = customer;
            Parts = parts;
        }
    }
}
