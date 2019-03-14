using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new[] {new Product("Laptop", 500),
                                        new Product("Tablet", 600),
                                        new Product("Smartphone", 700)
                                        };
            /*
            Product[] products2 = new Product[3];
            products2[0] = new Product("Printer", 300);
            products2[1] = new Product("Scanner", 200);
            products2[2] = new Product("Copier", 700);
            */

            SortedDictionary<int, Product> productDict = new SortedDictionary<int, Product>();
            // Adding object of product class to dictionary
            for (int i=0; i<products.Length; ++i)
            {
                productDict.Add(i, products[i]);
            }

            // Displaying the values of the dictionary
            DisplayDict(productDict);
            // Method Call
            AverageDict(productDict);

        } // end Main()

        private static void DisplayDict(SortedDictionary<int, Product> proDict)
        {
            foreach(var key in proDict.Keys )
            {
                Console.WriteLine($" Key:{key} , Value:{proDict[key]}");
                //Console.WriteLine($" Key:{key} , Value:{proDict[key].Name}");
                //Console.WriteLine($" Key:{key} , Value:{proDict[key].Price}");
            }

        } // end method

        private static void AverageDict(SortedDictionary<int, Product> avgDict)
        {
            double sum = 0;
            foreach (var key in avgDict.Keys)
            {
               sum = sum + avgDict[key].Price;
            }

            Console.WriteLine($" Average Product Price: {sum/avgDict.Keys.Count}");

        } // end method

    } // end class
} // end namespace
