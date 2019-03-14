using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mainul_Haque_COMP_212_sec_002_LinkedListLibrary;

namespace Mainul_Haque_COMP_212_002_LinkedListTest
{
    public static class Extension
    {
        
        public static T Min<T>(this Mainul_Haque_COMP_212_sec_002_LinkedListLibrary.List<T> li) where T : IComparable<T>
        {
            //Mainul_Haque_COMP_212_sec_002_LinkedListLibrary.List<T> lit = new Mainul_Haque_COMP_212_sec_002_LinkedListLibrary.List<T>();

            var a = li.showFirst();
            var v = li.showLast();
            var currentNode = a;
            if (li.IsEmpty())
            {
                throw new Exception("List iS emptY");
            }
            else
            {
                while (currentNode != null)
                {
                    
                    if (currentNode.CompareTo(v) > 0)
                    {
                        currentNode = a;
                    }
                    else
                    {
                        currentNode = v;
                    }
                }

            }
            return v;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Mainul_Haque_COMP_212_sec_002_LinkedListLibrary.List<double>();
            
            // use List insert methods       
            list.InsertAtFront(25.02);
            list.Display();
            list.InsertAtFront(12.30);
            list.Display();
            list.InsertAtBack(505.00);
            list.Display();
            list.InsertAtBack(20.69);
            list.Display();
            Console.WriteLine(list.Min());
        }
    }
}
