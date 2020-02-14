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

       public int GetPassmark()
        {
            return this._passmark;
        }
        public void SetName(String Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or negative");
            }
            this._name = Name; 
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            
            //if (String.IsNullOrEmpty(this._name))
            //{
            //    return "No Name";
            //}
            //else
            //{
            //    return this._name;
            //}
        }

        public void SetID(int ID)
        {
            if (ID <= 0)
            {
                throw new Exception("Student ID cannot be Negative");
            }
            this._id = ID;
        }

        public int GetID()
        {
            return this._id;
        }
    }
    class WhyProperties
    {
           public static void Main()
        {
            Student c1 = new Student();
            //c1.ID = -101;
            //c1.Name = null;
            //c1.PassMark = 0;

            c1.SetID(101);
            c1.SetName("Sanjeet Kumar");
            //Console.WriteLine("ID= {0} && Name = {1} && PassMark = {2}", c1.ID, c1.Name, c1.PassMark);

            Console.WriteLine("Student Id = {0}", c1.GetID());
            Console.WriteLine("Student Name = {0}", c1.GetName());
            Console.WriteLine("Student passmark = {0}", c1.GetPassmark());
        }
    }
}
