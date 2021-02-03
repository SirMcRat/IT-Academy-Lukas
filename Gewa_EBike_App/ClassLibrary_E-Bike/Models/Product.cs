namespace ClassLibraryEBike
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }

        public Product(int id, string name, string serialNumber, string type) : base(id)
        {
            Name = name;
            SerialNumber = serialNumber;
            Type = type;
        }
    }
}
