using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_assign_1_b__MainulHaque
{
    class Program
    {
        static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray contains: \n");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("\nArray doubleArray contains: \n");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("\nArray charArray contains: \n");
            DisplayArray(charArray); // pass a char array argument

            Console.WriteLine("Using overload method \n");
            int a = DisplayArray(charArray, 1, 4);
            Console.WriteLine("Number of elements shown -- {0}", a); //implement overload method

            int b = DisplayArray(intArray, 1, 4);
            Console.WriteLine("Number of elements shown -- {0}", b);

            int c = DisplayArray(doubleArray, 1, 5);
            Console.WriteLine("Number of elements shown -- {0}", c);          
        }

        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        //overload method
        private static int DisplayArray<T>(T[] inputArray, int low, int high)
        {

            if (low < 0 || high > inputArray.Length)
            {
                throw new ArgumentException(String.Format("Out of range exception............"));
            }
            else
            {
                int count = 0;
                for (int i = low; i < high; i++)
                {
                    Console.Write($"{inputArray[i]} ");
                    count++;
                }

                Console.WriteLine();
                return count;
            }

        }
    }
       
}
    

