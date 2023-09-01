using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class ReferenceType
    {
        class Person
        {
            public string Name;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person person1 = new Person();  // Reference type 
                person1.Name = "Alice";

                Person person2 = person1;  // Both person1 and person2 reference the same object

                person2.Name = "Bob";  // Changing name through person2 affects person1

                Console.WriteLine("person1 Name: " + person1.Name);  // Output: person1 Name: Bob
                Console.WriteLine("person2 Name: " + person2.Name);  // Output: person2 Name: Bob
            }
        }
    }
}
