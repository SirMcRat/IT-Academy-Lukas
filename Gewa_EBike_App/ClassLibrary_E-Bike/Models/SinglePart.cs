using System;

namespace ClassLibraryEBike
{
    public class SinglePart : Product
    {
        public SinglePartType Type { get; set; }
        public Company Supplier { get; set; }
        public int StorageAmount { get; private set; }

        public SinglePart(string name, string serialNumber, SinglePartType type, Company supplier, int storageAmount) : base(name, serialNumber)
        {
            Type = type;
            Supplier = supplier;
            StorageAmount = storageAmount;            
        }

        public void AddStorage(int amount)
        {
            StorageAmount += amount;
        }

        public void SubstractStorage(int amount)
        {
            StorageAmount -= amount;
        }
    }
}
