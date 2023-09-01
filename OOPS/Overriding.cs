using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Overriding
    {
            public class Interest
            {
                public virtual double TrueBank(double amount, double rate)
                {
                    return amount + (amount * rate);
                }
            }
            // first child class
            public class SimpleInterest : Interest
            {
                public override double TrueBank(double amount, double rate)
                {
                    return amount + (amount * rate) + 1000;
                }
            }
            // second child class
            public class FixedInterest : Interest
            {
                public override double TrueBank(double amount, double rate)
                {
                    return amount + (amount * rate) + 1500;
                }
            }
          
    }
}
