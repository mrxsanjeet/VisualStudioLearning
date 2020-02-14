using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passmark = 35;
        public string Email{get;set;}
        public string City{get;set;}
        public int Passmark
        {
            get
            {
                return this._passmark;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or negative");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student ID cannot be Negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

    }

    class Properties
    {
        public static void Main()
        {
            Student c1 = new Student();
            c1.Id = 101;
            
            c1.Name = "Sanjeet kumar singh";
            Console.WriteLine("Student Id = {0}", c1.Id);
            Console.WriteLine("Student Name = {0}", c1.Name);
            Console.WriteLine("Student passmark = {0}", c1.Passmark);
        }
    }
}
