using System;
using System.Collections.Generic;

namespace ClassBasics
{
    class DelegatesBasics1
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { ID = 101, Name = "sanjeet kumar", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 102, Name = "arnav kumar", Salary = 4000, Experience = 4 });
            emplist.Add(new Employee() { ID = 103, Name = "ajit kumar", Salary = 6000, Experience = 6 });
            emplist.Add(new Employee() { ID = 104, Name = "pramod kumar", Salary = 3000, Experience = 3 });

            Employee.PromoteEmployee(emplist);
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeelist)
        {
            foreach(Employee employee in employeelist)
            {
                if (employee.Experience > 5)
                {
                    Console.WriteLine(employee.Name + "  - Promoted");
                }
            }
        }

    }
}
