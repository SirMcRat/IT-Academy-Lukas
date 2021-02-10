using System;
using ClassLibraryEBike;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClassesOOP1();
        }

        private static void TestClassesOOP1()
        {
            var stromer = new Company(1, "Stromer AG", "Irgendeinestrasse 42", "3042", "Ortschaft");
            var FenderScrew1 = new SinglePart(1, "Fender Screw short", "FE-10001", "Screw", stromer, 0);
            var FenderScrew2 = new SinglePart(2, "Fender Screw long", "FE-10002", "Screw", stromer, 0);
            SinglePart FenderPlate1 = new SinglePart(3, "Fender Plate front", "FE-10003", "Plate", stromer, 0);
            Console.WriteLine("Bitte Anfangswerte eingeben: ");
            Console.Write("Fender Screw short: ");
            FenderScrew1.StorageAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fender Screw long: ");
            FenderScrew2.StorageAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fender Plate front: ");
            FenderPlate1.StorageAmount = Convert.ToInt32(Console.ReadLine());
            ProductPart FenderST3Screw1 = new ProductPart(1, FenderScrew1, 2);
            ProductPart FenderST3Screw2 = new ProductPart(2, FenderScrew2, 3);
            ProductPart FenderST3Plate1 = new ProductPart(3, FenderPlate1, 1);
            ProductPart[] FenderST3Parts = new ProductPart[3];
            FenderST3Parts[0] = FenderST3Screw1;
            FenderST3Parts[1] = FenderST3Screw2;
            FenderST3Parts[2] = FenderST3Plate1;
            EndProduct FenderST3 = new EndProduct(1, "Fender ST3 Assembled", "FE-20003", "Mudguard Assembled", stromer, FenderST3Parts);
            Console.Write("wie viele ST3 Schutzbleche sind bestellt? ");
            PartialOrder PartialOrder1 = new PartialOrder(1, InOut.outgoing, FenderST3, Convert.ToInt32(Console.ReadLine()));
            int arrayLength = FenderST3Parts.Length;
            thisIsATest(); 
            for (int i = 0; i < arrayLength; i++)
            {
                ProductPart ThisPart = FenderST3Parts[i];
                ThisPart.Part.StorageAmount -= ThisPart.Amount * PartialOrder1.Amount;
                Console.WriteLine("Es sind neu " + ThisPart.Part.StorageAmount + " " + ThisPart.Part.Name + " im Lager.");
            }
            Console.ReadLine();
        }
        private static void thisIsATest()
        {

        }
    }
}
