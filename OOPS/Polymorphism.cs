using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Polymorphism
    {
        public class TestOverloading
        {

            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two String :" + a1 + a2);
            }

            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integer :" + a1 + a2);
            }

        }
    }
}
   

