using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    public class Customer
    {
        internal string name;

        public int ID { get; set; }
        public string Name { get; set; }
    }
    class ExampleforSturctClass
    {
        public static void Main()
        {
            int i = 10;
            int j = i;
            j = j + 1;

            Console.WriteLine("i= {0} && j= {1}", i, j);

            Customer c1 = new Customer();
            c1.ID = 101;
            c1.Name = "Sanjeet kumar";
            Customer c2 = c1;

            c2.Name = "Merry";

            Console.WriteLine("c1.name= {0} && c2.name= {1} ", c1.Name, c2.Name);

        }
    }
}
