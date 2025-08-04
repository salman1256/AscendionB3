using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray
{
    /// <summary>
    /// Single Dimensional Array(1D) :
    /// </summary>
 //DataType[] ArrayName = new DataType[size];

    //Index:  from 0 to size-1

//int[] marks = new int[6];
 //0	1 	2	3	4	5


    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] marks = new int[6];
            //for(int i = 0; i < marks.Length; i++) 
            //{
            //    Console.WriteLine($"Enter Marks Obtained in Subject {i+1}");
            //    marks[i] = int.Parse( Console.ReadLine() );
            //}
            //Console.WriteLine("Stored Values as follows!!!");
            //Console.WriteLine("Subject \t Marks");
            //for (int i = 0; i < marks.Length; i++)
            //{

            //    Console.WriteLine("Subject "+(i+1)+"\t"+marks[i]);
            //}
            //Console.ReadKey();
            //var ,dynamic
            //string[] students = {"Arsh","Maan","Ravi","Sam","Viz","Sudhir" };
            //Console.WriteLine("Student List");
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);

            //}
            //Console.ReadKey();

            //var myVar = 12;
            //Console.WriteLine("Stored Value:\t"+myVar +"\tDataType: \t"+myVar.GetType());

            //var myVar2 = "Sam";
            //Console.WriteLine("Stored Value:\t" + myVar2 + "\t DataType: \t" + myVar2.GetType());
            //var myVarf = 12.5F;
            //Console.WriteLine("Stored Value:\t" + myVarf + "\t DataType: \t" + myVarf.GetType());
            //var myVard = 12.5;
            //Console.WriteLine("Stored Value:\t" + myVard + "\t DataType: \t" + myVard.GetType());
            //var myVarDecimal = 12.5M;
            //Console.WriteLine("Stored Value:\t" + myVarDecimal + "\t DataType: \t" + myVarDecimal.GetType());

            //dynamic[] myCollection = { 1,2,3,4,5,6,"Laptop",new DateTime() };
            //Console.WriteLine("Student List");
            //foreach ( var item in myCollection)
            //{
            //    Console.WriteLine(item);

            //}

            //Console.ReadKey();
            //string[,] rectArray = new string[4, 3];
            //for (int i = 0; i < rectArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < rectArray.GetLength(1); j++)
            //    {
            //        rectArray[i, j]="["+i +","+j+"]";
            //    }
            //}
            //Console.WriteLine("Stored Indexes");
            //for (int i = 0; i < rectArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < rectArray.GetLength(1); j++)
            //    {
            //        Console.Write(rectArray[i,j]);
            //    }
            //    Console.WriteLine("\n");
            //}
            //int[][] numbers = new int[4][];
            //numbers[0] =new [4]{ 1, 2, 3, 4 };
            //numbers[1] = new int[6] { 10, 20, 30, 40, 50, 60 };
            //numbers[2] = new int[3] { 100, 200, 300 };
            //numbers[3] = new int[5] { 1000, 2000, 200, 5000, 2 };
            //for(int i = 0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine($"Array Number {i+1}");
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j]+"\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            int noc, nos;
            Console.WriteLine("Enter Nubmer of classes");
            noc=int.Parse(Console.ReadLine());
            string[][]studentNames = new string[noc][];
            for(int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"Enter Number of students in class {i+1}");
                nos = int.Parse(Console.ReadLine());
                studentNames[i] = new string[nos];
                for(int j = 0; j < studentNames[i].Length; j++)
                {
                    Console.WriteLine($"Enter Student{j+1}\'s Name of class {i+1}");
                    studentNames[i][j]=Console.ReadLine();
                }
            }
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"Class {i + 1}\'s Student List");
                for (int j = 0; j < studentNames[i].Length; j++)
                {
                    Console.Write(studentNames[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
                Console.ReadKey();
        }
    }
}
