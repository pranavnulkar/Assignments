using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    class _26_09_2024
    {

        public abstract class Shape
        {
            public abstract double CalculateArea();

            public virtual void Display() 
            {
                Console.WriteLine($"This Is a {GetType().Name}");
            }
        }

        public class Circle : Shape
        {
            //override calculateArea Method
            public override double CalculateArea()
            {
                double pi = 3.141;
                Console.WriteLine("Enter Radius To Calculate Area Of Circle:- ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = 0;
                area= pi * radius * radius;
                Console.WriteLine($"Area Of Circle Is:- {area}");
                return area;
            }

            //override display method 
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Formula For Calculate Area Of Circle= PI*R*R (Pi Value Constant = 3.141)");
            }
        }

        public class Rectangle : Shape
        {
            //override calculateArea Method 
            public override double CalculateArea()
            {
                Console.WriteLine();
                Console.WriteLine("Enter Length to Calculate Area Of Rectangle:- ");
                double length=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Width To Calculate Area of Rectangle:- ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = 0;
                area = length * width;
                Console.WriteLine($"Area Of Rectangle Is:- {area}");
                return area;
            }

            //override Display Method 
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Formula For Calculate Area Of Rectangle:- Length * Width");
            }
        }

        static void Main()
        {
            Circle circle = new Circle();
            circle.CalculateArea();
            circle.Display();

            Rectangle rec = new Rectangle();
            rec.CalculateArea();
            rec.Display();
        }
    }
}
