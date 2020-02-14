using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);

        }
    }

    public class FullTimeEmployee : Employee
    {
        //public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        //public float HourlyRate;
        //new keyword is used to hide the base metheod because have same name method in base class
        public new void PrintFullName()
        {
            //base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + "- Contractor");

        }
    }
    class MethodHiding
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Sanjeet";
            FTE.LastName = "Kumar";
            FTE.PrintFullName();

            //Employee PTE = new PartTimeEmployee();
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Sanjeet";
            PTE.LastName = "Kumar singh";
            PTE.PrintFullName();
            //((Employee) PTE).PrintFullName();//typecasting the object calling
        }
    }
}
