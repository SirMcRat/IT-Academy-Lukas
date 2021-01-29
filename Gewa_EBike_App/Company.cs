namespace ClassLibraryEBike
{
    public class Company:Entity
    {    
        public string Name { set; get; }
        public string Address { set; get; }
        public string Zip { set; get; }
        public string City { set; get; } 
        
        public Company(int iD, string name, string address, string zip, string city):base(iD)
        {
            Name = name;
            Address = address;
            Zip = zip;
            City = city;
        }
    }
}
