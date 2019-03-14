using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Assign_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Students> linkStudents = new LinkedList<Students>();
            
            //adding new object in Students 
            Students student = new Students(101, "Ram");
            Students student1 = new Students(102, "Sam");
            Students student2 = new Students(103, "Rabi");
            Students student3 = new Students(104, "Luka");
            Students student4 = new Students(105, "Mina");
            Students student5 = new Students(106, "Shan");

            //Adding 5 student object to linkList
            AddLinkedListItem(linkStudents, student);
            AddLinkedListItem(linkStudents, student1);
            AddLinkedListItem(linkStudents, student2);
            AddLinkedListItem(linkStudents, student3);
            AddLinkedListItem(linkStudents, student4);
            Console.WriteLine("List of Student after add");
            PrintList(linkStudents); //display linkLIst elements

            //Remove item from linkList
            RemoveLinkedListItem(linkStudents, student1);
            PrintList(linkStudents);

            //Search item in LinkList
            SearchLinkedListItem(linkStudents, student1);
            Console.WriteLine("\nafter remove item from Link List \n");

            //Remove all item from Link LIst
            RemoveAllLinkedListItem(linkStudents);
            PrintList(linkStudents);


        }

        private static void AddLinkedListItem(LinkedList<Students> name, Students st)
        {
            name.AddLast(st);
        }

        // display list contents

        private static void PrintList(LinkedList<Students> name)
        {
            Console.WriteLine("Student List : ");

            foreach (var value in name)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine("\n");
        }
        // delete list items
        private static void RemoveLinkedListItem(LinkedList<Students> name, Students st)
        {
            LinkedListNode<Students> currentNode = name.Find(st);
            
                name.Remove(currentNode); // remove next node
            
        }
        // Search list items
        private static void SearchLinkedListItem(LinkedList<Students> name, Students st)
        {
            LinkedListNode<Students> currentNode = name.Find(st);

            if (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
            }
            else
            {
                Console.WriteLine("\n This Student not exists in Student List \n");
            }
            

        }
        // delete all list items
        private static void RemoveAllLinkedListItem(LinkedList<Students> name)
        {

            LinkedListNode<Students> currentNode = name.First;


            while (currentNode != null)
            {
                name.Remove(currentNode); 
                currentNode = name.First; //  next node become first node now            
            }

        }

    }
}
