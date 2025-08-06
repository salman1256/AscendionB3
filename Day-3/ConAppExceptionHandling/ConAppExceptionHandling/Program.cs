using System;

namespace ConAppExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int fNum, sNum, result;
                Console.WriteLine("Enter First Number");
                fNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                sNum = int.Parse(Console.ReadLine());
                result = fNum + sNum;
                Console.WriteLine($"Result after addding {fNum} and {sNum} = \t {result}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Please enter only numbers");
                Console.WriteLine(fe.Message);
            }
            catch (Exception ex) 
            { Console.WriteLine("Error!!!"+ex.Message); }
            

            finally 
            {
                Console.WriteLine("Finish!!!");
                Console.ReadKey(); 
            }
          
          


        }
    }
}
