using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab2
{
    interface ICalc
    {
        void Addnum(int a, int b);
        void Subnum(int a, int b);
        void Mulnum(int a, int b);
        void Divnum(int a, int b);
    }

    class Calculator : ICalc
    {
        public void Addnum(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }
        public void Subnum(int a, int b)
        {
            Console.WriteLine("Sub: " + (a - b));
        }
        public void Mulnum(int a, int b)
        {
            Console.WriteLine("Mul: " + (a * b));
        }
        public void Divnum(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Quotient: " + (a / b));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
    internal class Interface
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            calc.Addnum(10, 22);
            calc.Subnum(10, 5);
            calc.Mulnum(9, 18);
            calc.Divnum(47, 5);
        }
    }
}
