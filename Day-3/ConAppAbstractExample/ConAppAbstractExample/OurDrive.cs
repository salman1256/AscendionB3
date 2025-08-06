using System;


namespace ConAppAbstractExample
{
    public class OurDrive : OurAbClass
    {
        string msg;
        public override string OurAbPorp { get => msg; set => msg = value; }

        public override void Welcome(string msg)
        {
            Console.WriteLine("Welcome: Here is a  message for you " + msg);
        }
    }
}
