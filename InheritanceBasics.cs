﻿using System;
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
        public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    class InheritanceBasics
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Sanjeet";
            FTE.LastName = "Kumar";
            FTE.yearlySalary = 50000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Sanjeet";
            PTE.LastName = "Kumar singh";
            PTE.HourlyRate = 60000;
            PTE.PrintFullName();

        }
    }
}
