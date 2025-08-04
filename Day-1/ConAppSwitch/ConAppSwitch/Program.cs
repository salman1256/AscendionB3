//using System;
//namespace ConAppSwitch
//{
//    internal class Program
//    {    static void Main(string[] args)
//        {
//            string cCode, lang, choice;
//            do
//            {
//                Console.WriteLine("Enter Country Code e.g. us");
//                cCode = Console.ReadLine();
//                switch (cCode.ToLower())
//                {
//                    case "uk":
//                    case "us":
//                        {
//                            lang = "English";
//                            break;
//                        }
//                    case "in":
//                        {
//                            lang = "Hindi, Urdu, Punjanbi, Tamil,Telgu..................";
//                            break;

//                        }
//                    default:
//                        {
//                            Console.WriteLine("Your country is not registered in our database");
//                            lang = "Not Found";
//                            break;
//                        }
//                    case "de":
//                        {
//                            lang = "German";
//                            break;
//                        }
//                    case "af":
//                        {
//                            lang = "Dari, Pahtoo";
//                            break;
//                        }
//                    case "om":
//                    case "ksa":
//                    case "egypt":
//                    case "uae":
//                        {
//                            lang = "Arabic";
//                            break;
//                        }
//                }
//                Console.WriteLine($"Country Code: \t {cCode.ToUpper()} \t Language(s)\t {lang.ToUpper()}");
//                Console.WriteLine("Do you wanna continue... if yes press y");
//                choice = Console.ReadLine().ToLower();
//            } while (choice=="y");

//        }
//    }
//}
//Write a program to find out the table of given number.
//User can execute the program as many time as he wish to contiue....

using System;
namespace ConAppSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  choice;
            int number;
            do
            {
                Console.WriteLine("Enter Number to find out table");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Table of Number: {number} as follows");
                for(int i=1;i<=10;i++)
                {
                    Console.WriteLine($"{number}*{i}= \t {number*i}");
                }
                Console.WriteLine("Do you wanna continue... if yes press y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");

        }
    }
}