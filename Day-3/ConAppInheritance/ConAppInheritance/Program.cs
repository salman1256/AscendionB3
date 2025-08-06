using System;
namespace ConAppInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dev objDev= new Dev();
            //objDev.Register();
            //objDev.Display();
            Emp objEmp = new Emp(11,"Sunil",76000.57);
            objEmp.Display();
            Dev objDev= new Dev(15,"Sunita",85000.45,"dotnet","face-recogn");
          
            objDev.Display();
            Console.ReadKey();
        }
    }
}
