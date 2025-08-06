//using System;
//namespace ConAppInterface
//{
//    public class OurClass : IOne,ITwo
//    {
//        public void Display()
//        {
//            Console.WriteLine("Display Method of interface IOne");
//        }

//        public string Welcome(string name)
//        {
//            return "Welcome to Interfaces Mr.\\Ms. " + name;
//        }
//    }
//}
using System;
namespace ConAppInterface
{
    public class OurClass : IOne, ITwo
    {
        void IOne.Display()
        {
            Console.WriteLine("I am coming from Interface One");
        }

        void ITwo.Display()
        {
            Console.WriteLine("Hi,This is interface two display");
        }
    }
}
