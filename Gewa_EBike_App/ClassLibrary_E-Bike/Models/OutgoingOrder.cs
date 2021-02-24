using System;
using System.Linq;

namespace ClassLibraryEBike
{
    public class OutgoingOrder : Order
    {
        public DateTime OrderDate { get; set; }
        public Company Supplier { get; set; }        

        public OutgoingOrder(DateTime orderDate, Company supplier) : base()
        {
            OrderDate = orderDate;
            Supplier = supplier;
        }

        public override void CreatePartialOrder(Product product, int amount)
        {
            if (product is SinglePart part)
            {
                if (part.Supplier == Supplier)
                {
                    var partialOrder = new PartialOrder(product, amount);
                    PartialOrders.Add(partialOrder);
                }
                else
                {
                    throw new Exception("wrong Supplier");
                }
            }

            else
            {
                throw new Exception("SinglePart only");
            }
        }

        public override void ClearPartialOrders()
        {
            foreach (var PartialOrder in PartialOrders)
            {
                SinglePart part = (SinglePart)PartialOrder.Product;
                part.AddStorage(PartialOrder.Amount);
            }
        }
    }
}
