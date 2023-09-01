using System;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;
using static OOPS.Abstraction;
using static OOPS.Encapsulation;
using static OOPS.Inheritance;
using static OOPS.Overriding;
using static OOPS.Polymorphism;
using static OOPS.TypesOfMethods;
using static OOPS.TypesOfVariables;

namespace OOPS
{
    internal class Program
    {

        /* class Dog
         {
            public string breed;


             public void display()
             {
                 Console.WriteLine(breed);

                 Console.WriteLine("Bark Bark !!");

             }
         }*/
        static void Main(string[] args)
        {

            /* Dog bullDog = new Dog();

         Dog bullDog1 = new Dog();

         bullDog.breed = "Huskey";

         bullDog1.breed = "Bull Dog";

         bullDog.display();
         bullDog1.display();*/

            //single inheritance
            //Multi Level inheritance


            /* Dog2 dog = new Dog2();
             dog.eat();
             dog.run();
             dog.bark();*/

            /*Hierarchical Inheritance
            Cat cat = new Cat();
            cat.bark();
            cat.eat();
            Dog dog = new Dog();    
            dog.bark();
            dog.eat();*/


            //Compile-Time Polymorphism Method OverLoading
            /*  TestOverloading obj = new TestOverloading();

              obj.Add("vamshi ", "Reddy");

              obj.Add(5, 10);*/


            // Dynamic or Overriding Method in polymorphism

            /*  Interest interest = new Interest();
              Interest i = new Interest();
              double finalamount = i.TrueBank(5000.00, 0.1);
              Console.WriteLine("Normal interest for a holder " + finalamount);

              i = new SimpleInterest();
              finalamount = i.TrueBank(5000.00, 0.1);
              Console.WriteLine("Simple interest for a holder " + finalamount);

              i = new FixedInterest();
              finalamount = i.TrueBank(5000.00, 0.1);
              Console.WriteLine("Fixed interest for a holder " + finalamount);*/


            //Encapsulation Using Getter and Setter Methods

            /* encapsulation obj = new encapsulation();

             obj.Name ="vamshi ";


             obj.Age = 25;

             Console.WriteLine(" Name : " + obj.Name);
             Console.WriteLine(" Age : " + obj.Age);*/



            //Abstraction Abstract class and method

            /*  Ferrari f1 = new Ferrari();
              f1.brand();
              Bmw b1 = new Bmw();
              b1.brand();*/


            //Interface

             Rectangle r1 = new Rectangle();
             r1.CalculateArea(100, 200);


            //6) Create a program to demonstrate types of variables present in c#.

            /*  Variables v1 = new Variables();

              v1.details();*/


            // Methods
           /* Method.SayHello();
            Method.Add(33,34);
            Method m1 = new Method();
            m1.dog();*/
        }

    }

}