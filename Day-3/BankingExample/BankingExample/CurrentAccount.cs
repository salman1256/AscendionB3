using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExample
{
    public class CurrentAccount : IAccount
    {
        double currentBalance;
        public CurrentAccount()
        {
            currentBalance = 55000;
        }
        public double Balance => currentBalance;

        public double Deposit(double amount)
        {
           currentBalance += amount;
            Console.WriteLine($"Amount{amount} Deposited in your Current Account");
            return currentBalance;
        }

        public double Withdraw(double amount)
        {
            if (currentBalance > amount)
            {
                currentBalance -= amount;

                Console.WriteLine("Transaction Success!!!");

            }
            else {
                Console.WriteLine("Insufficient Amount in Your Current Account");
                Console.WriteLine("Transaction Failed");
            }
            return currentBalance;
        }
    }
}
