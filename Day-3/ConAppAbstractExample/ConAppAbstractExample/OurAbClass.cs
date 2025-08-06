using System;


namespace ConAppAbstractExample
{
    //[AS] abstract class <className> {//body of class}
   public abstract class OurAbClass
    {
        int ourField;
        public OurAbClass()
        {
            Console.WriteLine("Abstract class Constructor!!!");
            ourField = 1;
        }
        public int OurProp { get { return ourField; }
            set { ourField = value; } }
       
        //non abstract method
        public void Display()
        {
            Console.WriteLine("Display Method of Abstract Class!!!");
        }
         public abstract void Welcome(string msg);
         public abstract string OurAbPorp { get; set; }
    }
}
