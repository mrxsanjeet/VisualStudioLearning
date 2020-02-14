using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base class Print Method");
        }
    }
    public class DerivedBaseClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Derived class Print Method");
        }

        //public new void Print() Hiding the derived class method with new keyword
        //{
        //    Console.WriteLine("I am a Derived class Print Method");
        //}
    }
    class MORvsMH
    {
        public static void Main()
        {
            BaseClass b = new DerivedBaseClass();
            b.Print();
        }
    }
}
