// Fig. 19.17: QueueTest.cs
// Testing class QueueInheritance.
using System;
using QueueInheritanceLibrary;
using LinkedistLibrary;


// demonstrate functionality of class QueueInheritance
class QueueTest
{
   static void Main()
   {
      QueueInheritance queue = new QueueInheritance();

      // create objects to store in the queue
      
        string aString = "hello";
        string bString = "my";
        string cString = "name iS";
        string dString = "MainuL";


      // use method Enqueue to add items to queue
      queue.Enqueue(aString);
      queue.Display();
      queue.Enqueue(bString);
      queue.Display();
      queue.Enqueue(cString);
      queue.Display();
      queue.Enqueue(dString);
      queue.Display();

      // use method Dequeue to remove items from queue
      object removedObject = null;

      // remove items from queue
      try
      {
         while (true)
         {
            removedObject = queue.Dequeue();
            Console.WriteLine($"{removedObject} dequeued");
            queue.Display();
         }
      }
      catch (EmptyListException emptyListException)
      {
         // if exception occurs, write stack trace
         Console.Error.WriteLine(emptyListException.StackTrace);
      }
   }
}

