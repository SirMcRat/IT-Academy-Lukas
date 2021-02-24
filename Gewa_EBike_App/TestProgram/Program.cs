using System;
using System.Collections.Generic;
using ClassLibraryEBike;
using System.Linq;

namespace TestProgram
{
    
    class Program
    {
        private static List<Company> Companies;

        static void Main(string[] args)
        {
            CreateObjects();
        }
        public static void CreateObjects()
        {
            CreateCompanies();
            CreateSingleParts();
            CreateEndProducts();
            RunDialogue();
        }

        public static void CreateCompanies()
        {
           
            Companies.Add(new Company("Stromer AG", "Beispielstrasse 7", "3032", "Something"));
        }

        public static void CreateSingleParts()
        {
            var fenderScrewLong = new SinglePart("Fender Screw long", "st-0017800", 0, (Company)(from Company c in Companies where c.Name.Equals("Stromer AG") select c), 10000);
            var fenderScrewShort = new SinglePart("Fender Screw schort", "st-0017800", 0, (Company)(from Company c in Companies where c.Name.Equals("Stromer AG") select c), 10000);
            Console.WriteLine($"{fenderScrewLong.Id}  {fenderScrewShort.Id}");
        }

        public static void CreateEndProducts()
        {
            throw new NotImplementedException();
        }

        public static void RunDialogue()
        {
            throw new NotImplementedException();
        }
    }
        
}
