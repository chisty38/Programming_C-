using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> coursesDict = new SortedDictionary<int, string>();
            // Adding elements to dictionary
           
            coursesDict.Add(101, "Programming I");
            coursesDict.Add(123, "Programming II");
            coursesDict.Add(212, "Programming III");
            coursesDict.Add(229, "Java Programming");

            // Displaying the values

            foreach (KeyValuePair<int, string> pair in coursesDict)
            {
                //Console.WriteLine("${pair.Key},{pair.Value}");
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }

            // Searching for a given value based on key/value
            if(coursesDict.ContainsKey(101))
                Console.WriteLine("Value : {0}", coursesDict[101]);

            if (coursesDict.ContainsValue("Java Programming"))
                Console.WriteLine("\nElement present");

            // Adding one more element
            coursesDict.Add(100, "Software Engineering");

            // Removing an element
            coursesDict.Remove(212);

            // Displaying the values after printing
            foreach (KeyValuePair<int, string> pair in coursesDict)
            {
                //Console.WriteLine("${pair.Key},{pair.Value}");
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
            
            // Counting number of elements in the dictionary
            Console.WriteLine("\nTotal elements present: {0}", coursesDict.Count);

            // Printing all the keys
            
            // Printing all the values

        }
    }
}
