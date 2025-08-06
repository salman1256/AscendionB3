using System;

namespace ConAppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurClass obj = new OurClass();
            //obj.Display();
            //Console.WriteLine(obj.Welcome("A.Viz"));
            OurClass obj = new OurClass();
            ITwo itwo = obj;
            itwo.Display();

            IOne one=new OurClass();
            one.Display();

            Console.ReadKey();
        }
    }
}
