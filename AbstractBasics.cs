using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    // Abstract class
    public abstract class Customer
    {
        int ID;
        // Abstract method (does not have a body)
        public abstract void Print();
        
    }

    public interface ICustomer
    {

        
        void Print();

    }

    class AbstractBasics : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
        public static void Main()
        {
            //AbstractBasics Ab = new AbstractBasics();
            //Ab.Print();

            Customer c = new AbstractBasics();
            c.Print();

        }
    }
}
