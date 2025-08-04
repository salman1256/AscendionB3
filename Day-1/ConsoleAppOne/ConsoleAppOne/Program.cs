using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");
            //Console.Write("Welcome Again");
            //DataType variableName;
            //string userName;
            //Console.WriteLine("Enter User Name");
            //userName = Console.ReadLine();
            //Console.WriteLine("Welcome Mr.\\Ms."+userName );
            string fname, lname;
            int age;
            char grade;
            double fee;
            DateTime doj;
            Console.WriteLine("Enter First Name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            lname = Console.ReadLine();
            Console.WriteLine("Enter Age");
            //DataType.Parse(Console.ReadLine());
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fee");
            fee = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("********************************************************");
            Console.WriteLine(" First Name: \t" + fname + "\n Last Name: \t" + lname + "\n Age: \t" + age + "\n Grade: \t " + grade
                + "\n Fee: \t" + fee + "\n Date of Joining: \t " + doj);
            Console.WriteLine("********************************************************");
            Console.WriteLine
           ("Welcome Mr.\\Ms {1} \n First Name: \t {0} \n Last Name: \t {1} \n Age: \t {2} \n Grade: \t  {3} \n Fee: \t {4}\n Date of Joining: \t{5}",
           fname,lname,age,grade,fee,doj);
            Console.WriteLine("********************************************************");
            Console.WriteLine
         ($"Welcome Mr.\\Ms {fname} \nFirst Name: \t {fname} \n Last Name: \t {lname} \n Age: \t {age} \n Grade: \t {grade} \n Fee: \t {fee}\n Date of Joining:\t{doj}"
         );
            Console.ReadKey();

        }
    }
}
