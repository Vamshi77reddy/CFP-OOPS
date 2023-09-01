using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class TypesOfMethods
    {
        public class Method
        {
            // Static method with no parameters and no return value
           public static void SayHello()
            {
                Console.WriteLine("Hello!");
            }

            // Static method with parameters and a return value
           public static int Add(int a, int b)
            {
                return a + b;
                Console.WriteLine();
            }

            // Instance method
            public void dog()
            {
                Console.WriteLine("This is a dog");
            }
        }
    }
}