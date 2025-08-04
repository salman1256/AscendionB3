using System;


namespace ConAppGoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Again:
            Console.WriteLine("Enter Username");
            userName = Console.ReadLine();
            if(userName.Length>=6)
            {
                Console.WriteLine("Welcome "+userName);
            }
            else
            {
                Console.WriteLine("Username must have at least 6 characters");
                goto Again;
            }
            Console.ReadKey();

        }
    }
}
