namespace ClassLibraryEBike
{
    public class SinglePart:Product
    {     
        public Company Supplier { set; get; }
        public int StorageAmount { set; get; }

        public SinglePart(int iD, string name, string serialNumber, string type, Company supplier, int storageAmount):base(iD, name, serialNumber, type)
        {
            Supplier = supplier;
            StorageAmount = storageAmount;
        }
    }
}
