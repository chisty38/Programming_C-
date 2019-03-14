// Example of Expression Lambdas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressLambda02
{
    class Program
    {
        // Here is a delegate type that is compatible with lambda expression used here:
        delegate bool DelRange(int lower, int upper, int v);
        static void Main(string[] args)
        {
           // Here is an example that uses a lambda expression to
           //  determine if a value is within a specified range:
        DelRange rangeOK = (low, high, val) => (val >= low && val <= high);
           
            // After doing so, the lambda expression can be executed as shown here:
            if (rangeOK(10, 15, 3))
             Console.WriteLine("3 is within the range.");
            else
                Console.WriteLine("3 is not within the range.");
        }
    }
}
