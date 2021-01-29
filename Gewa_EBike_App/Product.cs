namespace ClassLibraryEBike
{
    public class Product:Entity
    {
        public string Name { set; get; }
        public string SerialNumber { set; get; }
        public string Type { set; get; }

        public Product(int iD, string name, string serialNumber, string type):base(iD)
                {
                    Name = name;
                    SerialNumber = serialNumber;
                    Type = type;
                }
    }
}
