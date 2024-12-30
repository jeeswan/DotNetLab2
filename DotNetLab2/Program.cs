using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab2
{
    internal class Program
    {
        class ImmutableString
        {
            static void Main(string[] args)
            {
                string orginalString = "hello";
                string newString = orginalString;
                Console.WriteLine("New string:" + newString);
                orginalString = "meow";
                Console.WriteLine("New String remains unchanged: " + newString);


            }
        }
    }
}
