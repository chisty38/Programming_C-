// Fig. 19.14: StackInheritanceTest.cs
// Testing class StackInheritance.
using System;
using StackInheritanceLibrary;
using LinkedistLibrary;

// demonstrate functionality of class StackInheritance
class StackInheritanceTest
{
   static void Main()
   {
      StackInheritance stack = new StackInheritance();

      // create objects to store in the stack
      double a = 25.02;
      double b = 20.35;
      double c = 34.56;
      double d = 65.25;
      //string aString = "hello";

      // use method Push to add items to stack
      stack.Push(a);
      stack.Display();
      stack.Push(b);
      stack.Display();
      stack.Push(c);
      stack.Display();
      stack.Push(d);
      stack.Display();
        var f = stack.peek();
        Console.WriteLine("\nTop element of the stack iS  "+f+"\n");
        

      // remove items from stack
      try
      {
         while (true)
         {
            double removedObject = stack.Pop();
            Console.WriteLine($"{removedObject} popped");
            stack.Display();
         }
      }
      catch (EmptyListException emptyListException)
      {
         // if exception occurs, write stack trace
         Console.Error.WriteLine(emptyListException.StackTrace);
      }
   }
}

