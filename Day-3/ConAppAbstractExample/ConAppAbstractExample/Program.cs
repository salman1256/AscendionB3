using System;
namespace ConAppAbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurAbClass obj=new OurAbClass(); //Error Can't create instance of abstract class
            
            OurDrive obj=new OurDrive();
            obj.Display();
            obj.Welcome("Welcome to abstract classess!!!");
            obj.OurProp = 12;
            obj.OurAbPorp = "Same like simple property";
            Console.WriteLine
             ($"Stored value in OurProp {obj.OurProp} & OurAbProp {obj.OurAbPorp}");
            Console.ReadKey();
        }
    }

    
}
