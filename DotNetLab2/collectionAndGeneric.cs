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

                List<int> numbers = new List<int>();


                for (int i = 1; i <= 10; i++)
                {
                    numbers.Add(i);
                }

                Console.WriteLine("Numbers from 1 to 10:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
