// Fig. 20.1: OverloadedMethods.cs
// Using overloaded methods to display arrays of different types.
using System;

class OverloadedMethods
{
   static void Main(string[] args)
   {
      // create arrays of int, double and char
      int[] intArray = {1, 2, 3, 4, 5, 6};
      double[] doubleArray = {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7};
      char[] charArray = {'H', 'E', 'L', 'L', 'O'};

      Console.Write("Array intArray contains: ");
      DisplayArray(intArray); // pass an int array argument
      Console.Write("Array doubleArray contains: ");
      DisplayArray(doubleArray); // pass a double array argument
      Console.Write("Array charArray contains: ");
      DisplayArray(charArray); // pass a char array argument
      DisplayArray(charArray, 2, 3);
      DisplayArray(intArray, 3);

    }
    //assignment
    private static int DisplayArray<T>(T[] inputArray, int low, int high)
    {
        if (low < 0 || high > inputArray.Length)
        {
            throw new ArgumentException(String.Format("out of range exception"));
        }
        else
        {
            for (int i = low; i <= high; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }

            Console.WriteLine();
            return high;
        }


    }

    // output int array                                 
    private static void DisplayArray<T>(T[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }

    //generics overload
    private static void DisplayArray<T1, T2>(T1[] inputArray, T2 num)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }

    //generics overload
    private static void DisplayArray<T1>(T1[] inputArray, int num)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} "+num);
        }

        Console.WriteLine();
    }

    // adding generics by adding <T> and changed signature we implement generics

    // output int array                                 
    private static void DisplayArray(int[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }

    // along with generics non generics method is allowed 


    /*
       // output int array                                 
       private static void DisplayArray(int[] inputArray)
       {
          foreach (var element in inputArray)
          {
             Console.Write($"{element} ");
          }

          Console.WriteLine();
       }

       // output double array                                 
       private static void DisplayArray(double[] inputArray)
       {
          foreach (var element in inputArray)
          {
             Console.Write($"{element} ");
          }

          Console.WriteLine();
       }

       // output char array                                 
       private static void DisplayArray(char[] inputArray)
       {
          foreach (var element in inputArray)
          {
             Console.Write($"{element} ");
          }

          Console.WriteLine();
       }*/
}

