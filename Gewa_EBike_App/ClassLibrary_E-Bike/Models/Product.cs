namespace ClassLibraryEBike
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
       
        public Product(int id, string name, string serialNumber) : base(id)
        {
            Name = name;
            SerialNumber = serialNumber;
        }
    }
}
