using System;

namespace ConAppInheritance
{
    public class Emp
    {
        //int id;
        //    string name;
        //    double salary;
        //    public Emp()
        //    {
        //        Console.WriteLine("Constructor of Emp Class!!!");
        //        id = -1;
        //        name = "not given";
        //        salary = 0.0;

        //    }
        //    public virtual  void Display()
        //    {
        //        Console.WriteLine("ID: \t"+id);
        //        Console.WriteLine("Name: \t" + name);
        //        Console.WriteLine("Salary: \t" + salary);
        //    }
        //    public virtual void Register()
        //    {
        //        Console.WriteLine("Enter Id");
        //        id=int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter Name");
        //        name=Console.ReadLine();
        //        Console.WriteLine("Enter Salary");
        //        salary=double.Parse(Console.ReadLine());
        //
        //Example -2
        int id;
        string name;
        double salary;
        public Emp(int id, string name, double salary)
        {
          
            this.id = id;
            this.name = name;   
            this.salary = salary;
        }
        public virtual void Display()
        {
            Console.WriteLine("ID: \t" + id);
            Console.WriteLine("Name: \t" + name);
            Console.WriteLine("Salary: \t" + salary);
        }
       

    }
}
