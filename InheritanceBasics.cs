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
            

        }
    }

    public class FullTimeEmployee : Employee
    {
        float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        float HourlyRate;
    }
    class InheritanceBasics
    {
        public static void Main()
        {

        }
    }
}
