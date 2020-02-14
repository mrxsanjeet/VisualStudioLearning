using System;

namespace ClassBasics
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintfullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }


    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintfullName()
        {
            Console.WriteLine(FirstName + "" + LastName + "- Full Time Employee");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintfullName()
        {
            Console.WriteLine(FirstName + "" + LastName + "- Part Time Employee");
        }
    }

    public class TemporaryPartTimeEmployee : Employee
    {
        public override void PrintfullName()
        {
            Console.WriteLine(FirstName + "" + LastName + "- Temporary Part Time Employee");
        }
    }

    internal class Polymorphism
    {
        public static void Main()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new TemporaryPartTimeEmployee();
            employees[3] = new FullTimeEmployee();

            foreach(Employee e in employees)
            {
                e.PrintfullName();
            }
        }
    }
}