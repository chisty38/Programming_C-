using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class AnonymousWithArgsTest
    {
        // Declare a delegate type.
        delegate void DelCount(int end);
        static void Main(string[] args)
        {
            // Here, the ending value for the count
            // is passed to the anonymous method.
            DelCount count = delegate (int end) 
            {
                for (int i = 0; i <= end; i++)
                    Console.WriteLine(i);
            };
            count(3);
            Console.WriteLine();
            count(5);
        } // end Main
    }
}
