using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assign_1_a_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1;
            int min;
            int max;

            Console.WriteLine("How many number you want to add in number list\n");
            
            num1 = int.Parse(Console.ReadLine()); // Read and convert number of list user wants to generate

            //declare and initial array
            int[] intArray = new int[num1];
            double[] doubleArray = new double[num1];

            // use rendom class to generate number
            Random r = new Random();
            Console.WriteLine("Type lowest value and highest value to generate int and double value\n");
            min = int.Parse(Console.ReadLine());
            max = int.Parse(Console.ReadLine());

            // assigning rendom number to int array

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = r.Next(min, max);
            }

            // assigning rendom number to int array

            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = min + (r.NextDouble() * (max - min));
            }

            //display list of int array

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            
            //display list of double array

            foreach (double items in doubleArray)
            {
                Console.WriteLine("{0:f2}", items);
            }

            Console.WriteLine("\n");

            // ask user to type num from int number list to search from list following type for seach number double list

            Console.WriteLine("type a num you want to search from number list");

            int getnum = int.Parse(Console.ReadLine());

          
           // Search if num exists in intArray

            int result = Array.BinarySearch(intArray, getnum);
            Console.WriteLine(result >= 0 ?
               $"num found at element {result} in intValues" :
               "-1");

            Console.WriteLine("\n");

            // ask user to type num from int number list to search from list

            Console.WriteLine("type a num you want to search from number list");

            Double getDouble = Double.Parse(Console.ReadLine());


            // Search if num exists in DoubleArray

            int resultDouble = Array.BinarySearch(doubleArray, getDouble);
            Console.WriteLine(resultDouble >= 0 ?
               $"num found at element {resultDouble} in doubleArray" :
               "-1");
        }
    }
}
