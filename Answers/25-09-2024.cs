using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    class _25_09_2024
    {
        //Method Overloading/early binding/compile time /static polymorphism 
        class Calculator
        {
            public int Add(int a,int b)
            {
                return a + b;
            }

            public int Add(int a,int b,int c)
            {
                return a + b + c;
            }

            public double Add(double a,double b)
            {
                return a + b;
            } 

            public int Add(int[] number)
            {
                int sum = 0;
                foreach(var num in number)
                {
                    sum += num;
                }
                return sum;
            }

            public object Add(string a ,string b)
            {
                return (Convert.ToDouble(a) + Convert.ToDouble(b));
            }
        }
        
        
        class Animal
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing A Shape");
            }
        }
        class Circle : Animal
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing A Circle");
            }
        }

        class Rectangle : Animal
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing A Rechtangle");
            }
        }


        static void Main()
        {
            Console.WriteLine("Method Overloading");
            Calculator cal=new Calculator();
            int first = cal.Add(5, 5);
            int second = cal.Add(10, 20, 30);
            double third = cal.Add(10.5, 85.7);
            int fourth = cal.Add(new int[] { 20,30,6,40});
            object fifth = cal.Add(12.5, 22.5);

            Console.WriteLine($"Addition Of Two Integers:- {first} ");
            Console.WriteLine($"Addition Of Three Integers:- {second} ");
            Console.WriteLine($"Addition Of Two Double:- {third} ");
            Console.WriteLine($"Addition Of Array (20,30,6,40):- {fourth} ");
            Console.WriteLine($"Addition Of Two Strings:- {fifth}");
            Console.WriteLine();


            //Method Override/late binding/run time polymorphism/Dynamic Polymorphism
            Console.WriteLine("Method Overriding");
            Animal animal = new Animal();
            Circle circle = new Circle();
            Rectangle rec = new Rectangle();

            animal.Draw();
            circle.Draw();
            rec.Draw();
        }
    }
}
