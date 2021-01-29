namespace ClassLibraryEBike
{
    public class EndProduct : Product
    {
        public Company Customer { get; set; }
        public ProductPart[] Parts { get; set; }

        public EndProduct(int id, string name, string serialNumber, string type, Company customer, ProductPart[] parts) : base(id, name, serialNumber, type)
        {
            Customer = customer;
            Parts = parts;
        }
    }
}
