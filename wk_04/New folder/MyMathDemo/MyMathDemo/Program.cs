using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mYMathLib;
namespace MyMathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass mc = new MyMathClass();

            Console.WriteLine("My sqaure area is "+ mc.MySquare(5));

            Console.WriteLine("My sqaure area is " + mc.MyCube(5));
        }
    }
}
