using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace ClassBasics
{
    class LateBindingExample
    {
        private static void Main()
        {
            // Load the current executing assembly as the Customer1 class is present in it.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
                       
            // Load the Customer class for which we want to create an instance dynamically
            Type customerType = executingAssembly.GetType("ClassBasics.Customer1");
            // Create the instance of the customer type using Activator class 
            object customerInstance = Activator.CreateInstance(customerType);
            // Get the method information using the customerType and GetMethod()
            MethodInfo getFullName = customerType.GetMethod("GetFullNames");
            // Create the parameter array and populate first and last names
            string[] methodParameters = new string[2];
            methodParameters[0] = "Sanjeet"; //FirstName
            methodParameters[1] = "kumar";     //LastName
            // Invoke the method passing in customerInstance and parameters array
            string fullName = (string)getFullName.Invoke(customerInstance, methodParameters);
            Console.WriteLine("Full Name = {0}", fullName);
        }
    }
    public class Customer1
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
