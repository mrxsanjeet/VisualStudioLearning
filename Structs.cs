using System;

namespace ClassBasics
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name { get => _name; set => _name = value; }

        public Customer(int Id, String Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("ID= {0} && Name= {1}", this._id, this._name);
        }
    }

    internal class Structs
    {
        public static void Main()
        {
            Customer c1 = new Customer(101, "Sanjeet Kumar singh");
            c1.PrintDetails();

            Customer c2 = new Customer();
            c2.ID = 102;
            c2.Name = "Arnav singh";
            c2.PrintDetails();

            Customer c3 = new Customer
            {
                ID = 103,
                Name = "Seema singh"
            };
            c3.PrintDetails();
        }
    }
}