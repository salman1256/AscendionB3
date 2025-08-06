using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExample
{
    public class SavingAccount : IAccount
    {
        double savingBal;
        public SavingAccount()
        {
            savingBal = 20000;
        }
        public double Balance => savingBal;

        public double Deposit(double amount)
        {
            savingBal += amount;
            Console.WriteLine($"Amount {amount} deposited in your Saving Account");
            return savingBal;
        }

        public double Withdraw(double amount)
        {
            if(savingBal < amount)
            {
                Console.WriteLine("Insufficient Amount in Your Saving Account!!!");


            }
            else
            {
                if(savingBal-amount>=5000)
                {
                    savingBal -= amount;
                    Console.WriteLine("Transaction Success!!!");
                }
                else
                {
                    {
                        Console.WriteLine("MAB: 5K !!! Transaction Declined");
                    }
                }
            }
            return savingBal;
        }
    }
}
