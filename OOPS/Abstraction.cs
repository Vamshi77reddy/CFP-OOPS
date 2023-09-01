using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Abstraction
    {
       public  abstract class Car
        {
            public abstract void brand();
        }
       public  class Ferrari : Car {
        public override void brand()
            {
                Console.WriteLine("This is Ferrari car");            }
                }
      public  class Bmw : Ferrari {
            public override void brand()
            {
                Console.WriteLine("This is BMW car");
            }
        }
    }
}
