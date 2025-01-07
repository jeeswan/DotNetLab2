using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab2
{
    class dictionary
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store customer information
            Dictionary<int, string> customers = new Dictionary<int, string>();

            // Add customer data to the dictionary
            customers.Add(01, "Prashant");
            customers.Add(02, "Ujan");
            customers.Add(03, "Manjit");
            customers.Add(04, "Swopnil");

            // Print the customer information
            Console.WriteLine("Customer List:");
            foreach (KeyValuePair<int, string> customer in customers)
            {
                Console.WriteLine($"CustomerId: {customer.Key}, CustomerName: {customer.Value}");
            }
        }
    }
}
