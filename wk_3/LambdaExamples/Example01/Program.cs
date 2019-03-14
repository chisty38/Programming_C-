using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
            // Declare a delegate that takes an int argument
            // and returns an int result.
            delegate int Incr(int v);
            // Declare a delegate that takes an int argument
            // and returns a bool result.
            delegate bool IsEven(int v);
class SimpleLambdaDemo
        {
            static void Main()
            {
                // Create an Incr delegate instance that refers to
                // a lambda expression that increases its parameter by 2.
                Incr incr = count => count + 2;
            //  Incr incr = (int count) => count + 2; // You can specify the type of count if you want
            // Now, use the incr lambda expression.
            Console.WriteLine("Use incr lambda expression: ");
                int x = -10;
                while (x <= 0)
                {
                    Console.Write(x + " ");
                    x = incr(x); // increase x by 2
                }
                Console.WriteLine("\n");
                // Create an IsEven delegate instance that refers to
                // a lambda expression that returns true if its parameter
                // is even and false otherwise.
                IsEven isEven = n => n % 2 == 0;
                
            // Now, use the isEven lambda expression.
                Console.WriteLine("Use isEven lambda expression: ");
                for (int i = 1; i <= 10; i++)
                    if (isEven(i))
                    Console.WriteLine(i + " is even.");

            } // end Main
        }
    }
   
