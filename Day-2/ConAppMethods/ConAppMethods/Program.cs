using System;

//[AS][Mod] class <ClassName>[:BaseClassName]
//{Body of class}
//ClassName <objectName>=new ClassName();
//objectName.MemberName
//------------------------
//[AS][Mod] returnType <MethodName>(parameters){//Body of method}
//Datatype or void
//1.instance Method : objectName.MethodName(arguments);
//2.static Method: ClassName.MethodName(arguments);
//3.abstract
//4.partial
//5.extension

namespace ConAppMethods
{
    internal class Program
    {
        public static void Print()
        {
            Console.WriteLine("Hi!!!, I'm printing for you");
        }
        static void Main(string[] args)
        {   Authentication authentication = new Authentication();
            string uName,uPassword;
            Console.WriteLine("Enter User Name");
            uName =Console.ReadLine();
            Console.WriteLine("Enter User Password");
            uPassword = Console.ReadLine();
            Console.WriteLine(authentication.SignIn(uName, uPassword));
            Console.ReadKey();


            //OurClass obj = new OurClass();
            ////
            //obj.Display();
            //double fNum, sNum;
            //string name;
            //Console.WriteLine("Enter Name");
            //name= Console.ReadLine();   
            //Console.WriteLine("Enter first Number");
            //fNum=double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second Number");
            //sNum = double.Parse(Console.ReadLine());
            //double res = obj.Add(fNum,sNum);
            //obj.Welcome(name);
            //Console.WriteLine($"Result after adding {fNum} and {sNum} = \t {res}");
            //OurClass.Print();
            //Print();
            Console.ReadKey();
        }
    }
}
