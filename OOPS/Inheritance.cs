using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Inheritance
    {
        // Single Inheritacne
        public class Animal
        {
            public void eat()
            {
                Console.WriteLine("Eating food");
            }
        }
        public class Dog : Animal
        {
            public void bark()
            {
                Console.WriteLine("Bow bow");
            }
        }
        public class Dog2 : Dog 
        {
        public void run()
            {
                Console.WriteLine("Dog is running");
            }
        }

        /* 
                 Hierarchical Inheritance

          public class Dog : Animal
          {
              public void bark()
              {
                  Console.WriteLine("Bow Bowww");
              }
          }
          public class Cat : Animal {
              public void bark()
              {
                  Console.WriteLine("Meow meow");
             }
          }*/


    }
}