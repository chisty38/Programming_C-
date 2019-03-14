using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainuL_Haque_Excercise_03
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

            // order the invoice by Invoice total --3(a)
            var QuantitySorted =
               from e in invoice
               orderby e.invoiceTotal
               select new { e.PartNumber, e.PartDescription, e.quantity, e.price, e.invoiceTotal };

            // display all invoice after sort by Quatity
            Console.WriteLine("\ninvoice list displayed after sorted by Total price --- \n");
            foreach (var element in QuantitySorted)
            {
                Console.WriteLine(element);
            }

            //--3(b)
            var ToatalSorted =
              from e in invoice
              where e.invoiceTotal >= 150 & e.invoiceTotal <= 550
              orderby e.invoiceTotal
              select new { e.PartNumber, e.PartDescription, e.quantity, e.price, e.invoiceTotal };

            // display all invoice after sort by Quatity
            Console.WriteLine("\ninvoice list displayed after sorted by total price range from 150 to 550 --- \n");
            foreach (var element in ToatalSorted)
            {
                Console.WriteLine(element);
            }
        }
    }
 }

