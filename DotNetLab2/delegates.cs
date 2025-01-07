using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab2
{
    internal class delegates
    {
        // Define a class containing the delegate and methods
        delegate int OperationDelegate(int a, int b);

        class Program
        {
            static void Main(string[] args)
            {
                OperationDelegate addDelegate = (a, b) => a + b;

                Console.WriteLine("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());


                int result = addDelegate(num1, num2);

                // Display the result
                Console.WriteLine($"The sum of {num1} and {num2} is: {result}");
            }
        }
    }
}
