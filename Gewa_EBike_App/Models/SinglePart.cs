namespace ClassLibraryEBike
{
    public class SinglePart : Product
    {     
        public Company Supplier { get; set; }
        public int StorageAmount { get; set; }

        public SinglePart(int id, string name, string serialNumber, string type, Company supplier, int storageAmount) : base(id, name, serialNumber, type)
        {
            Supplier = supplier;
            StorageAmount = storageAmount;
        }
    }
}
