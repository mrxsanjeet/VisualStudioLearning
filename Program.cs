using System;

namespace ClassBasics
{
    class Customer
    {
        public string _firstName;
        public string _secondName;

        public Customer() : this("No Firstname is provided","No Secondname is provided")
            {
            
            }

        public Customer(string FirstName, string SecondName)
        {
            this._firstName = FirstName;
            this._secondName = SecondName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full name = {0}", _firstName + " " + _secondName );
        }

        ~Customer()
        {
            //Clean up code
        }
    }
    class Program
    {
        static void Main()
        {
            //Customer c1 = new Customer("Sanjeet", "Kumar");
            Customer c2 = new Customer();
            c2.PrintFullName();
            
        }
    }
}
