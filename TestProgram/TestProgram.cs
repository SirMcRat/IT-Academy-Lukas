using ClassLibraryEBike;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProgram.Program
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            TestClassesOOP1();
        }
        public static void TestClassesOOP1()
        {
            Company Stromer = new Company(1, "Stromer AG", "Irgendeinestrasse 42", "3042", "Ortschaft");
            SinglePart FenderScrew1 = new SinglePart(1, "Fender Screw short", "FE-10001", "Screw", Stromer, 100);
            SinglePart FenderScrew2 = new SinglePart(2, "Fender Screw long", "FE-10002", "Screw", Stromer, 200);
            SinglePart FenderPlate1 = new SinglePart(3, "Fender Plate front", "FE-10003", "Plate", Stromer, 50);
            ProductPart FenderST3Screw1 = new ProductPart(1, FenderScrew1, 2);
            ProductPart FenderST3Screw2 = new ProductPart(2, FenderScrew2, 3);
            ProductPart FenderST3Plate1 = new ProductPart(3, FenderPlate1, 1);
            ProductPart[] FenderST3Parts = new ProductPart[3];
            FenderST3Parts[0] = FenderST3Screw1;
            FenderST3Parts[1] = FenderST3Screw2;
            FenderST3Parts[2] = FenderST3Plate1;
            EndProduct FenderST3 = new EndProduct(1, "Fender ST3 Assembled", "FE-20003", "Mudguard Assembled", Stromer, FenderST3Parts);
            PartialOrder PartialOrder1 = new PartialOrder(1, 0, FenderST3, 22);

        }
    }
}
