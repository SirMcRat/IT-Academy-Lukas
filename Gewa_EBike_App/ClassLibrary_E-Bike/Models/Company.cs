namespace ClassLibraryEBike
{
    public class Company : Entity
    {    
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; } 
        
        public Company(string name, string address, string zip, string city) : base()
        {
            Name = name;
            Address = address;
            Zip = zip;
            City = city;
        }
    }
}
