using System;

namespace ClassBasics
{
    interface ICustomer
    {
        void Print();
    }

    interface I2
    {
        void I2Method();
    }

    class Customer : ICustomer,I2
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }

        public void Print()
        {
            Console.WriteLine("Interface print Method");
        }
    }
    class IntroInterface
    {
        public static void Main()
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.I2Method();
        }
    }
}
