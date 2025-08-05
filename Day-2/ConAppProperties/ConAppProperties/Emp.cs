//using System;
//namespace ConAppProperties
//{
//    public class Emp
//    {
//        int id;
//        string name;
//        double salary;
//        public Emp()
//        {
//            Console.WriteLine("Employee Constructor");
//            id = -1;
//            name = "not given";
//            salary = 0;
//        }
//        public void Display()
//        {
//            Console.WriteLine("ID: \t"+id);
//            Console.WriteLine("Name: \t"+name);
//            Console.WriteLine("Salary:\t" + salary);
//        }
//        public void Register()
//        {
//            Console.WriteLine("Enter ID ");
//            id=int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Name ");
//            name=Console.ReadLine();
//            Console.WriteLine("Enter Salary ");
//            salary = double.Parse(Console.ReadLine());

//        }
//    }
//}
//using System;
//namespace ConAppProperties
//{
//    public class Emp
//    {
//        int id;
//        string name;
//        double salary;
//        public Emp()
//        {
//            Console.WriteLine("Default Constructor!!!");


//        }
//        public Emp(int _id, string _name, double _salary)
//        {
//            Console.WriteLine("Parameterized Constructor!!!!");
//            //this.id = id;
//            //this.name = name;   
//            //this.salary = salary;
//            id = _id;
//            name= _name;
//            salary= _salary;
//        }
//        public void Display()
//        {
//            Console.WriteLine("ID: \t" + id);
//            Console.WriteLine("Name: \t" + name);
//            Console.WriteLine("Salary:\t" + salary);
//        }

//    }
//}
using System;
namespace ConAppProperties
{
    //Propertes
    //[AS][Mod] DataType {get { return } set {value}}
    //1.Read Only : get
    //2.Write Only: set
    //3.Read&Write: get,set
    //4.Static Property
    //5.Abstract Property
    //6. AutoImplemented Property
    //    public class Emp
    //    {
    //        private int id;

    //        public int Id
    //        {
    //            get
    //            {
    //                Console.WriteLine("Invalid Id");
    //                return id; }
    //            set
    //            {
    //                if (value <= 0)
    //                {

    //                    id = -1;

    //                }
    //            }
    //        }

    //        private string name;

    //        public string Name
    //        {
    //            get { if (name== "invalid")
    //                {
    //                    Console.WriteLine("Invalid Name");
    //                }
    //                return name; }
    //            set {
    //                if (value.Length <= 5)
    //                { name = "invalid"; }
    //            }
    //        }
    //        private double salary;

    //        public double Salary
    //        {
    //            get { return salary; }
    //            set { salary = value; }
    //        }

    //        private static double tax;

    //        public static double Tax
    //        {
    //            get { return tax; }
    //            set { tax = value; }
    //        }




    //    }
    //}
    //AutoImplemented Property Example
    using System;
    namespace ConAppProperties
    {
        public class Emp
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Qualification { get; set; }
            public double Salary { get; set; }
        }
    }
}