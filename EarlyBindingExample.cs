using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    class EarlyBindingExample
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            string fullName = C1.GetFullName("Sanjeet", "kumar");
            Console.WriteLine("Full Name = {0}", fullName);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
