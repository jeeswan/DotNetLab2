using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab2
{
    // Custom exception for insufficient balance
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }
    class exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                // Read balance and withdraw amount from user
                Console.Write("Enter current balance: ");
                decimal balance = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter withdraw amount: ");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                // Perform withdrawal or throw exception
                if (withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine($"Withdrawal successful. Remaining balance: {balance}");
                }
                else
                {
                    throw new InsufficientBalanceException("Withdrawal amount exceeds current balance.");
                }
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }
    }
}
