using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples02
{
    class AnonymousWithoutArgsTest
    {
        // Declare a delegate type.
        delegate void DelCount();
        static void Main(string[] args)
        {
            // Demonstrate an anonymous method.
            // Here, the code for counting is passed
            // as an anonymous method.
            DelCount count = delegate 
            {
                // This is the block of code passed to the delegate.
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(i);
            }; // notice the semicolon

            count();
    } // end Main
    }
}
