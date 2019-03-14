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

        


        Console.WriteLine("Display number of elements\n");
        Console.WriteLine(list.count());
        Console.WriteLine("\nDisplay average number \n");
        Console.WriteLine(list.Avg());

        Console.WriteLine("\nFind elements from list\n");
        Console.WriteLine(list.search(505.00));
        Console.WriteLine("\n");
        // remove data from list and display after each removal
        try
      {
         object removedObject = list.RemoveFromFront();
         Console.WriteLine($"{removedObject} removed");
         list.Display();
            

            removedObject = list.RemoveFromFront();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine($"{removedObject} removed");
         list.Display();
      }
      catch (EmptyListException emptyListException)
      {
         Console.Error.WriteLine($"\n{emptyListException}");
      }
   }
}

