using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainuL_Haque_Excercise_02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Func<int, int, int, int> intCheck = Max;
            
            Console.WriteLine("Maximum value from 5, 6 and 7 is " + intCheck(5, 6, 7));

            Func<double, double, double, double> doubleCheck = Max;

            Console.WriteLine("\nMaximum value from 5.5, 6.6 and 7.7 is " + doubleCheck(5.5, 6.6, 7.7));

            Func<string, string, string, string> array1Check = Max;

            Console.WriteLine("\nMaximum value from he, she and the is " + array1Check("he","she","the"));

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Func<int[], int> arrayCheck = EvenSum;
            Console.WriteLine("\nSum of array is "+arrayCheck(numbers));

        }

        public static T Max<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            var max = num1; // assume x is initially the largest

            // compare y with max
            if (num2.CompareTo(max) > 0)
            {
                max = num2; // y is the largest so far
            }

            // compare z with max
            if (num3.CompareTo(max) > 0)
            {
                max = num3; // z is the largest
            }

            return max; // return largest object
        }
       

        public static int EvenSum(int[] array)
        {
            
            int sum = 0;
            foreach (var item in array)
            {
               
                if (item % 2 == 0) 
                {
                    sum += item;
                }
                
            }
            return sum;
        }
    }
}
