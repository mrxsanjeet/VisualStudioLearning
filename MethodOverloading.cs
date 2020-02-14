using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    class MethodOverloading
    {
        public void Main()
        {
            
        }

        public static void Add(int FN,int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN,int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN+TN);
        }

    }
}
