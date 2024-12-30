using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab2
{
    internal class collectionAndGeneric
    {
        class ArrayUsingGenerics
        {
            static void Main(string[] args)
            {
                // Declare a generic List to store numbers
                List<int> numbers = new List<int>();

                // Adding numbers to the List
                numbers.Add(10);
                numbers.Add(11);
                numbers.Add(12);
                numbers.Add(13);
                numbers.Add(14);

                // Display the numbers using a foreach loop
                Console.WriteLine("Numbers in the List:");
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }

                // Demonstrating additional features of List<T>
                Console.WriteLine("\nTotal Count of Numbers: " + numbers.Count);

                // Adding a new number
                numbers.Add(15);
                Console.WriteLine("After Adding 15:");

                // Display updated numbers
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
