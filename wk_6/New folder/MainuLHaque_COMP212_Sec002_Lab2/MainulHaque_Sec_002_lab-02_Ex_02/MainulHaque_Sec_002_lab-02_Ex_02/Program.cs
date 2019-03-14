using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainulHaque_Sec_002_lab_02_Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize array of invoice
            var invoice = new[] {
                new Invoice(87, "Electric Sander", 7, 57.98M),
                new Invoice(24, "Power Saw", 18, 99.99M),
                new Invoice(7, "Sledge Hammer", 11, 21.50M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn Mower", 3, 79.50M),
                new Invoice(68, "Screw Driver", 106, 6.99M),
                new Invoice(56, "Jig saw", 21, 11.00M),
            };

            // display all invoice
            Console.WriteLine("Original array:");
            foreach (var element in invoice)
            {
                Console.WriteLine(element);
            }

            // order the invoice by Part Description
            var PartSorted =
               from e in invoice
               orderby e.PartDescription
               select e;

            // display all invoice after sort by Part Description
            Console.WriteLine("\ninvoice list displayed sorted by part description --- \n");
            foreach (var element in PartSorted)
            {
                Console.WriteLine(element);
            }

            // order the invoice by Price
            var PriceSorted =
               from e in invoice
               orderby e.price
               select e;

            // display all invoice after sort by Price
            Console.WriteLine("\ninvoice list displayed sorted by price --- \n");
            foreach (var element in PriceSorted)
            {
                Console.WriteLine(element);
            }



            // order the invoice by Quatity
            var QuantitySorted =
               from e in invoice
               orderby e.quantity
               select new { e.PartDescription, e.quantity};

            // display all invoice after sort by Quatity
            Console.WriteLine("\ninvoice list displayed after sorted by Quatity --- \n");
            foreach (var element in QuantitySorted)
            {
                Console.WriteLine(element);
            }
        }


    }
}
