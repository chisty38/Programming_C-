using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AnonymousWithArgsReturnTest
    {
        // This delegate returns a value.
        delegate int DelCount(int end);
        static void Main(string[] args)
        {
            int result;
            // Here, the ending value for the count
            // is passed to the anonymous method.
            // A summation of the count is returned.
            DelCount count = delegate (int end) {
                int sum = 0;
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum; // return a value from an anonymous method
            };
            result = count(3);
            Console.WriteLine("Summation of 3 is " + result);
            Console.WriteLine();
            result = count(5);
            Console.WriteLine("Summation of 5 is " + result);
        } // end Main()
    }
}
