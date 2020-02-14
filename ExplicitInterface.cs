using System;

namespace ClassBasics
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class ExplicitInterface : I1,I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 interface Method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface Method");
        }
        public static void Main()
        {
            
            ExplicitInterface ex = new ExplicitInterface();
            
            ((I1)ex).InterfaceMethod();

            ((I2)ex).InterfaceMethod();
        }
    }
}
