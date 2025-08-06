using System;
namespace ConAppCustomException
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age;
                Console.WriteLine("Enter Age");
                age = int.Parse(Console.ReadLine());
                AgeValidator(age);
                Console.ReadKey();
            }
            catch(InvalidAgeException ex) {
                Console.WriteLine("Invalid Age Exception: \t"+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
        public static void AgeValidator(int age)
        {
            if(age<18||age>=120)
            {
                throw new InvalidAgeException($"{age} is invalid age must be in between 18years-120 years");
            }
            Console.WriteLine("Age is Valid");
            Console.WriteLine("Your age is: "+age);
        }
    }
}
