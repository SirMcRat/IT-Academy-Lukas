using System;

namespace ClassLibraryEBike
{
    public class IncomingOrder : Order 
    {
        public DateTime DueDate { get; set; }
        public Company Customer { get; set; }

        public IncomingOrder(DateTime dueDate, Company customer) : base()
        {
            DueDate = dueDate;
            Customer = customer;
        }

        public override void CreatePartialOrder(Product product, int amount)
        {
            if (product is EndProduct endProduct)
            {
                if (endProduct.Customer == Customer)
                {
                    var partialOrder = new PartialOrder(product, amount);
                    PartialOrders.Add(partialOrder);
                }
                else
                {
                    throw new Exception("wrong Customer");
                }
            }
            else
            {
                throw new Exception("EndProduct only");
            }
        }

        public override void ClearPartialOrders()
        {
            foreach (var PartialOrder in PartialOrders)
            {
                EndProduct product = (EndProduct)PartialOrder.Product;
                foreach (var ProductPart in product.Parts)
                {
                    var part = ProductPart;
                    int totalAmount = part.Amount * PartialOrder.Amount;
                    ProductPart.Part.SubstractStorage(totalAmount);
                }
            }
        }
    }
}
