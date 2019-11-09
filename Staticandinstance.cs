using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    class Circle
    {
        static float _PI;
        int _Radius;

        static Circle()
        {
            Circle._PI = 3.14f;
            //static constructor is called only at once
            //Static constructor is called before instance constructor
        }
        
        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return Circle._PI * this._Radius;
        }

        public static void Print()
        {
            //code
        }
    }
    
    class Staticandinstance
    {
        public static void Main()
        {
            Circle c1 = new Circle(5);
            float Area1 = c1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            Circle c2 = new Circle(6);
            float Area2 = c2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);
        }
    }
}
