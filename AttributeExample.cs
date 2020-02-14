using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    class AttributeExample
    {
        public static void Main()
        {
            Console.WriteLine("Adding two number");
            //Calculator.Add(10, 20);
            Calculator.Add(new List<int>(){ 10,20,30});
        }
    }
    public class Calculator
    {
        [Obsolete("Use Add(List<int> Numbers)")]
        public static int Add(int FirstNumber,int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach(int Number in Numbers)
            {
                sum = sum + Number;
            }
            return sum;
        }
    }
}
