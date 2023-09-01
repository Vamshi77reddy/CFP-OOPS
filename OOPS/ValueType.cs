using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class ValueType
    {
        class Program
        {
            static void Main(string[] args)
            {
                int num1 = 10;  // Value type (integer)
                int num2 = num1;  // Copy of num1

                num2 = 20;  // Changing num2 won't affect num1

                Console.WriteLine("num1: " + num1);  // Output: num1: 10
                Console.WriteLine("num2: " + num2);  // Output: num2: 20
            }
        }
    }
}
