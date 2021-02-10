namespace ClassLibraryEBike
{
    public class SinglePart : Product
    {
        public SinglePartType Type { get; set; }
        public Company Supplier { get; set; }
        public int StorageAmount { get; set; }

        public SinglePart(int id, string name, string serialNumber, SinglePartType type, Company supplier, int storageAmount) : base(id, name, serialNumber)
        {
            Type = type;
            Supplier = supplier;
            StorageAmount = storageAmount;            
        }
    }
}
