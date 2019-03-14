using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedEmployee
{
    class LinkedEmployeeTest
    {
        static void Main(string[] args)
        {
            string name;
            double salary;
            Employee employee = new Employee("Sujeet", 1200);
            Console.WriteLine($"\n Employee: {employee}");

            LinkedList<Employee> lnkEmployee = new LinkedList<Employee>();
           
            // adding employees to linked list
            Console.WriteLine("\nEnter Name and Salary:");
            for (int i=0; i<3; ++i)
            {
                name = Console.ReadLine();
                salary = double.Parse(Console.ReadLine());
                employee = new Employee(name, salary);
                lnkEmployee.AddLast(employee);
            }

            // Displaying Linked List Employee objects

                // iterate over the list by using the nodes                     
                LinkedListNode<Employee> currentNode = lnkEmployee.First;

                while (currentNode != null)
                {
                    // get value in node       
                    Console.WriteLine($"\n Employee Name: {currentNode.Value.Name}"); // convert to uppercase 
                    Console.WriteLine($"\n Employee Salary: {currentNode.Value.Salary}");
                    currentNode = currentNode.Next; // get next node             
                } // end while

           }// end Main

       

    } // end class
} // end Namespace
