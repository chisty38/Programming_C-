using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp1 = new Employee("Rani", 5800);
            Employee emp2 = new Employee("Hani", 4800);
            Employee emp3 = new Employee("Rani", 2800);
            Employee emp4 = new Employee("Hani", 3800);
            Employee emp5 = new Employee("Rani", 6800);
            Employee emp6 = new Employee("Hani", 1800);

            SortedDictionary<int, Employee> employeeList = new SortedDictionary<int, Employee>();

            
            // added 5 employee
            addDictionaryItem(employeeList, emp1);
            addDictionaryItem(employeeList, emp2);
            addDictionaryItem(employeeList, emp3);
            addDictionaryItem(employeeList, emp4);
            addDictionaryItem(employeeList, emp5);
            addDictionaryItem(employeeList, emp6);
            
            //display employee
            PrintDictionary(employeeList);

            //remove employee
            Console.WriteLine("Remove employee\n");
            RemoveDictionaryItem(employeeList, 5);
            PrintDictionary(employeeList);

            //search employee
            Console.WriteLine("\n");
            SearchDictionaryItem(employeeList, 2);

            //method for showing employee name who have max salary
            MaxDictionaryItem(employeeList);
        }

        //method to calculate max salary
        private static void MaxDictionaryItem(SortedDictionary<int, Employee> emploList)
        {
            var result = emploList.Values.OrderBy(Employee => Employee.salary).Last();            
            Console.WriteLine(result.ToString());       
        }

        //method to search employee
        private static void SearchDictionaryItem(SortedDictionary<int, Employee> empList, int v)
        {
            if (empList.ContainsKey(v))
                Console.WriteLine("Employee present: Value : {0}", empList[v]);
        }

        //method to remove employee

        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> employeeRemove, int v)
        {
            employeeRemove.Remove(v);
        }

        //method add employee 
        public static void addDictionaryItem(SortedDictionary<int, Employee> num, Employee emp)
        {
                num.Add(num.Count, emp);
        }

        //method to display all employee
        private static void PrintDictionary(SortedDictionary<int, Employee> emp)
        {
            foreach (var key in emp.Keys)
            {
                Console.WriteLine($" Key:{key} , Value:{emp[key]}");
                
            }

        } // end method

    }
}

