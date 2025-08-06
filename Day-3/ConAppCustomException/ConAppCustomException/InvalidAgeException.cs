using System;
namespace ConAppCustomException
{
    public class InvalidAgeException:Exception
    {
        public InvalidAgeException(string msg = "Invalid Age")
            : base(msg)
        {
            
        }
    }
}
