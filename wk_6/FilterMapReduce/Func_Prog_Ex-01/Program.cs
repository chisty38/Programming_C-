using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Prog_Ex_02
{
    class Program
    {
        delegate double FuncDel(double num);
        delegate double DelSquare(double number);
        static void Main(string[] args)
        {
            Func<double, double> fn = Math.Sin;
            Console.WriteLine($"Value of Sin: {fn(30.0) }");

            //user defined function for delegate
           FuncDel funcDel = Math.Sin;
            Console.WriteLine($"Value of Sin: {funcDel(30.0) }");


            fn = Program.Square;
            // calling user defined function
            Console.WriteLine($"Square of a number: {fn(5.00)}");


            Func<int, bool> evenOdd = Program.IsEven;
            // calling user defined function
            Console.WriteLine($"Given number is Even: {evenOdd(11)}");

            Func<string, string, string,  string> maxString = Program.Max;
            // calling user defined function-Max
            Console.WriteLine($"Largest String: {maxString("Sujeet", "Tin", "Zhing")}");

            Func<double, double, double> sum = Program.Sum;
            // calling user defined function-Sum
            Console.WriteLine($"Addition : { sum(12.5, 2.4)}");

            Func<double, double> delSq = Square;
            Console.WriteLine(delSq(4));

            Func<string, string, string, string> s4 = Max;
            Console.WriteLine(s4("me", "she", "he"));
            Console.WriteLine($"largest of three iS {s4("me", "she", "he")}");

            Func<double, double, double> dSum = sum;
            Console.WriteLine($"sum of two num is {dSum(5,6)}");

            Action<double> sq2 = Square2;
            sq2(5);


        } // end Main()

        private static void Square2(double num)
        {
            Console.WriteLine(num * num); 
        }

        // user defined function - Square
        private static double Square(double num)
        {
            return num * num;
        } // end Square

        private static bool IsEven(int number) => number % 2 == 0;
        // user defined function - IsEven
        private static bool MyIsEven(int num)
        {
            return num % 2 == 0;
        } // end IsEven

        // user defined function - Max
        private static string Max(string s1, string s2, string s3)
        {
            string max = s1;
            max = (s2.CompareTo(max) > 0) ? s2 : max;
            max = (s3.CompareTo(max) > 0) ? s3 : max;
            return max;
        } // end Max

        


        private static double Sum(double num1, double num2)
        {
            return num1 + num2;
        } // end Sum

    } // end class

} // end namespace
