using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    class EnumExample2
    {
        public static void Main()
        {
            int[] Values = (int[])Enum.GetValues(typeof(Gender));
            Console.WriteLine("Gender Enum Values");
            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }
                    Console.WriteLine();
        string[] Names = Enum.GetNames(typeof(Gender));
        Console.WriteLine("Gender Enum Names");
        foreach (string Name in Names)
        {
            Console.WriteLine(Name);
        }
        }
    }

    public enum Gender :int
    {
        Unknown=1,
        Male=2,
        Female=3
    }
}
