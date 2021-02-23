using System;

namespace ClassLibraryEBike
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
       
        public Product(string name, string serialNumber) : base()
        {
            Name = name;
            SerialNumber = serialNumber;
        }

    }
}
