//using System;
//namespace ConAppInheritance
//{
//   public  class Dev:Emp
//    {
//        string domain;
//        string project;
//        public Dev()
//        {
//            Console.WriteLine("Dev Class Constructor!!!");
//            domain = "unknown";
//            project = "not assign";
//        }
//        public override void Display()
//        {
//            base.Display();

//            Console.WriteLine("Domain: \t" + domain);
//            Console.WriteLine("Project: \t"+project);
//        }
//        public override void Register()
//        {
//            base.Register();
//            Console.WriteLine("Enter Domain");
//            domain=Console.ReadLine();
//            Console.WriteLine("Enter Project");
//            project=Console.ReadLine();
//        }
//    }
//}
//Example -2
using System;
namespace ConAppInheritance
{
    public class Dev : Emp
    {
        string domain;
        string project;
        public Dev(int id, string name, double salary, string project, string domain)
            :base(id,name, salary)
        {
             this.domain = domain;
            this.project = project;
        }
        public override void Display()
        {
            base.Display();

            Console.WriteLine("Domain: \t" + domain);
            Console.WriteLine("Project: \t" + project);
        }
        
    }
}
