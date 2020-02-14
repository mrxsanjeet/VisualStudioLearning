﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    // Delegate Declaration. 
public delegate void HelloFunctionDelegate(string Message);


class Pragim
{
    public static void Main()
    {
        // Create the instance of the delegate and pass in the function
        // name as the parameter to the constructor. The passed in
        // function signature must match the signature of the delegate
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        // Invoke the delegate, which will invoke the method
        del("Hello from Delegte");
    }


    public static void Hello(string strMessge)
    {
        Console.WriteLine(strMessge);
    }
}
}
