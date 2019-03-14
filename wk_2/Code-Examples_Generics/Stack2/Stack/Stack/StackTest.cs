// Fig. 20.9: StackTest.cs
// Testing generic class Stack.
using System;
using System.Collections.Generic;

class StackTest
{
   // create arrays of doubles and ints
   private static double[] doubleElements =
      {1.1, 2.2, 3.3, 4.4, 5.5, 6.6};
   private static int[] intElements =
      {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

   private static Stack<double> doubleStack; // stack stores doubles
   private static Stack<int> intStack; // stack stores ints

   static void Main()
   {
      doubleStack = new Stack<double>(5); // stack of doubles
      intStack = new Stack<int>(10); // stack of ints

      // push doubles onto doubleStack
      TestPush(nameof(doubleStack), doubleStack, doubleElements);
      // pop doubles from doubleStack
      TestPop(nameof(doubleStack), doubleStack);
      // push ints onto intStack
      TestPush(nameof(intStack), intStack, intElements);
      // pop ints from intStack
      TestPop(nameof(intStack), intStack);
   }

    // test Push method
    //private static void TestPush<T>(string name, Stack<T> stack, T[] elements)
   private static void TestPush<T>(string name, Stack<T> stack, IEnumerable<T> elements)
        
    {
      // push elements onto stack
      try
      {
         Console.WriteLine($"\nPushing elements onto {name}");

         // push elements onto stack
         foreach (var element in elements)
         {
            Console.Write($"{element} ");
            stack.Push(element); // push onto stack
         }
      }
      catch (FullStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
      }
   }

   // test Pop method
   private static void TestPop<T>(string name, Stack<T> stack)
   {
      // pop elements from stack
      try
      {
         Console.WriteLine($"\nPopping elements from {name}");

         T popValue; // store element removed from stack

         // remove all elements from stack
         while (true)
         {
            popValue = stack.Pop(); // pop from stack
            Console.Write($"{popValue} ");
         }
      }
      catch (EmptyStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
      }
   }
}

