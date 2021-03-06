// Fig. 20.8: StackTest.cs
// Testing generic class Stack.
using System;

class StackTest
{
   // create arrays of doubles and ints
   private static double[] doubleElements =
      {1.1, 2.2, 3.3, 4.4, 5.5, 6.6};
   private static int[] intElements =
      {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

  // private static Stack doubleStack; // stack stores doubles
   private static Stack intStack; // stack stores ints  

   static void Main()
   {
     // doubleStack = new Stack(5); // stack of doubles
      intStack = new Stack(10); // stack of ints

     // TestPushDouble(); // push doubles onto doubleStack
      //TestPopDouble(); // pop doubles from doubleStack
      TestPushInt(); // push ints onto intStack
      TestPopInt(); // pop ints from intStack
   }

   // test Push method with doubleStack


   // test Pop method with doubleStack
 

   // test Push method with intStack
   private static void TestPushInt()
   {
      // push elements onto stack
      try
      {
         Console.WriteLine("\nPushing elements onto intStack");

         // push elements onto stack
         foreach (var element in intElements)
         {
            Console.Write($"{element} ");
            intStack.Push(element); // push onto intStack
         }
      }
      catch (FullStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
      }
   }

   // test Pop method with intStack
   private static void TestPopInt()
   {
      // pop elements from stack
      try
      {
         Console.WriteLine("\nPopping elements from intStack");

         int popValue; // store element removed from stack

         // remove all elements from stack
         while (true)
         {
            popValue = intStack.Pop(); // pop from intStack
            Console.Write($"{popValue:F1} ");
         }
      }
      catch (EmptyStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
      }
   }
}

