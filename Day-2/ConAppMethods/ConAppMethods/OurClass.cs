using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethods
{
    public class OurClass
    {
        //no parameters, no return type i.e. void
        public void Display() 
        {
            Console.WriteLine("Welcome to Methods in C#");
        }
        //Single Parameter and void return type
        public void Welcome(string name)
        {
            
            Console.WriteLine("Welcome Again Mr.\\Ms."+name);
        }

        public double Add(double num1, double num2)
        {
            double result=num1 + num2;
            return result;
        }
        
    }
}
