// Fig. 19.5: ListTest.cs 
// Testing class List.
using System;

using LinkedistLibrary;

// class to test List class functionality
class ListTest
{
   static void Main()
   {
      var list = new List<double>(); // create List container

      

      // use List insert methods       
        list.InsertAtFront(25.02);
        list.Display();
        list.InsertAtFront(12.30);
        list.Display();
        list.InsertAtBack(505.00);
        list.Display();
        list.InsertAtBack(20.69);
        list.Display();
        var first = list.GetFirst();
        Console.WriteLine("\nFirst element from the list is "+first);
        var last = list.GetLast();
        Console.WriteLine("\nLast element from the list is " + last);


   }
}

