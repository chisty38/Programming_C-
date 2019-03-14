using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensioMethodDemo
{
    public static class Extension
    {
        public static double BDC(this Calculator cal, double d1, double d2)
        {
            return d1 * d2;
        }
        public static string Greetings(this Calculator cal)
        {
            return "Welcome to my class";
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cl = new Calculator();
            Console.WriteLine($"{cl.ADD(5, 6)}");
            Console.WriteLine($"{cl.Sub(10, 6)}");
            Console.WriteLine($"mY greetings: {cl.Greetings()}");
            Console.WriteLine($" multiply of two number iS {cl.BDC(5,9)}");
        }
    }
}
