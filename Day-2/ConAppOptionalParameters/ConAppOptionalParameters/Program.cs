using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOptionalParameters
{
    public class OurClass
    { 
        public void Add(int num1, int num2=100,int num3 = 200,int num4 = 50)
        { 
            int result=num1 + num2+num3+num4;
            Console.WriteLine($"Result after adding {num1},{num2},{num3}and {num4}=\t {result}");
        }
        public string FullName(string fname, string lname)
        {
            return fname + " " + lname;
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass obj = new OurClass();
            Console.WriteLine(obj.FullName("Sam", "Dicosta"));
            Console.WriteLine(obj.FullName(lname:"Dicosta", fname:"Sam"));
            DateTime date = new DateTime(day:26,month:12,year:2020);
            Console.WriteLine(date.ToShortDateString());
           
            //obj.Add(1,2,3,4);
            //obj.Add(1);
            //obj.Add(1, 2);
            //obj.Add(1, 30, 40);
            Console.ReadKey();
          
        }
    }
}
