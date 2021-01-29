namespace ClassLibraryEBike
{
    public class EndProduct:Product
    {
        public Company Customer { set; get; }
        public ProductPart[] Parts { set; get; }

        public EndProduct(int iD, string name, string serialNumber, string type, Company customer, ProductPart[] parts):base(iD, name, serialNumber, type)
        {
            Customer = customer;
            Parts = parts;
        }
    }
}
