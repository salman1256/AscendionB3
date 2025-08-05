using ConAppProperties.ConAppProperties;
using System;
namespace ConAppProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Emp obj = new Emp();
            ////Emp obj1=new Emp ();
            ////obj1.Register();
            ////Console.WriteLine("Fist Employee Details as follows");
            ////obj.Display();

            ////Console.WriteLine("Second Employee  Details as follows");
            ////obj1.Display();

            ////Console.ReadKey();
            //Emp obj = new Emp(11, "Neha Garg", 65000.45);
            //obj.Display();
            //Emp obj2 = new Emp();
            //obj2.Display();
            //Console.ReadKey();

            //Properties
            //Emp emp = new Emp();
            //Console.WriteLine("Enter Tax");
            //Emp.Tax=double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Id");
            //emp.Id=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //emp.Name=Console.ReadLine();
            //Console.WriteLine("Enter Salary");
            //emp.Salary = double.Parse(Console.ReadLine());
            //Console.WriteLine("ID: \t "+emp.Id);
            //Console.WriteLine("Name: \t " + emp.Name);
            //Console.WriteLine("Salary: \t " + emp.Salary);
            //Console.WriteLine("Tax"+Emp.Tax);
            //Console.ReadKey();
            Emp emp1 = new Emp()
            {
                Id = 1,
                Name = "Sam",
                Salary = 99000.90,
                Qualification = "MCA"
            };
            Emp emp2 = new Emp
            {
                Id = 2,
                Name = "Rohit",
                Qualification = "BTech",
                Salary = 95000.50
            };
            Console.WriteLine("Employee One Details as follows!!!");
            Console.WriteLine($"{emp1.Id}->{emp1.Name}->{emp1.Qualification}->{emp1.Salary}");
            Console.WriteLine("Employee Two Details as follows!!!");
            Console.WriteLine($"{emp2.Id}->{emp2.Name}->{emp2.Qualification}->{emp2.Salary}");
            Console.ReadKey();

        }
    }
}
