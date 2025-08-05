using System;
//Call By Value

namespace ConAppMethodParameters
{
    public class OurClass
    {
        //public void Increment(int num)
        //{
        //    Console.WriteLine($"Value of num inside Method before increment is =\t {num}");
        //    num += 5;
        //    Console.WriteLine($"Value of num inside Method after increment is =\t {num}");
        //}
        ////call by ref
        //public void Increment(ref int num)
        //{
        //    Console.WriteLine($"Value of num inside Method before increment is =\t {num}");
        //    num += 5;
        //    Console.WriteLine($"Value of num inside Method after increment is =\t {num}");
        //}
        //public void Increment(out int value) 
        //{
        //    value = 100;
           
        //    Console.WriteLine("Incremented value :\t "+value);
        //}

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //int myNum = 20;
            //Console.WriteLine($"Value of Mynum inside Main before Method Call =\t {myNum}");
            //OurClass obj=new OurClass();
            //obj.Increment(myNum);
            //Console.WriteLine($"Value of Mynum inside Main after Method Call =\t {myNum}");
            //Console.ReadKey();
            //Call By ref
            //int myNum = 20;
            //Console.WriteLine($"Value of Mynum inside Main before Method Call =\t {myNum}");
            //OurClass obj = new OurClass();
            //obj.Increment(ref myNum);
            //Console.WriteLine($"Value of Mynum inside Main after Method Call =\t {myNum}");
            //int number;
            //OurClass obj = new OurClass();
            //obj.Increment(out number);
            //Console.WriteLine("Value after method call: \t"+number);
            //Console.ReadKey();
            //double empSalary;
            //Console.WriteLine("Enter Salary");
            //empSalary = double.Parse(Console.ReadLine());   
            //Salary objSal=new Salary ();

            //objSal.BonusCalc(empSalary,out double empBonus);

            //Console.WriteLine($"Employee Salary: \t {empSalary} \n Bonus {empBonus}");
            //Param Example
            Salary obj=new Salary();
            Console.WriteLine(obj.TotalSalary(12000, 15000)); 
            Console.WriteLine(obj.TotalSalary(45000, 56000, 40000, 12000,45000,6000,9000));
            double fNum, sNum, tNum;
            fNum = 12;
            sNum = 13;
            tNum = 14;

            Console.WriteLine($"Result after adding {fNum} ,{sNum} and {tNum} is = \t {obj.TotalSalary(fNum, sNum, tNum)}");
            Console.ReadKey();


        }
    }
}
