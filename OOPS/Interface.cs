using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Interface
    {
        interface IPolygon
        {
            // method without body
            void CalculateArea(int l, int b);

        }

       public class Rectangle : IPolygon
        {

            // implementation of methods inside interface
            public void CalculateArea(int l, int b)
            {

                int area = l * b;
                Console.WriteLine("Area of Rectangle: " + area);
            }
        }

    }
}
    