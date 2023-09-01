using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Encapsulation
    {
        public class encapsulation
        {

            
            private String studentName;
            private int studentAge;

            public String Name
            {

                get { return studentName; }

                set { studentName = value; }
            }

            
            public int Age
            {

                get { return studentAge; }

                set { studentAge = value; }
            }
        }

    }
}
