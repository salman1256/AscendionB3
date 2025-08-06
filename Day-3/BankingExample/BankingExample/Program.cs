using System;
namespace BankingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("*** Welcome to our Banking System ***");
            Console.WriteLine("Choose Account Type 1. Saving 2. Current");
            int acType=int.Parse(Console.ReadLine());
            IAccount account;
            switch (acType)
            {
                case 1:
                    {
                       account = new SavingAccount();
                        break;
                    }
                    case 2:
                    {
                       account  = new CurrentAccount();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid operation Choice");
                        return;
                    }
            }
            Console.WriteLine("Choose operation \n 1.Balance \n 2.Deposit \n3. Withdraw");
            int op=int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {  Console.WriteLine("Balance: \t"+account.Balance);
                        break;
                    }
                case 2:
                    {   Console.WriteLine("Enter Amount to Deposit");
                        Console.WriteLine("Balance after Deposit: \t"+account.Deposit(double.Parse(Console.ReadLine())));
                        break;
                    }
                case 3:
                    {   Console.WriteLine("Enter Amount to Withdraw");
                        Console.WriteLine("Balance after Withdraw: \t" + account.Withdraw(double.Parse(Console.ReadLine())));
                        break;
                    }
                    default:
                    {  Console.WriteLine("Invalid operation Choice!!!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
