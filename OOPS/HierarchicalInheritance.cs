using Assignments.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPS
{

    class Shape
    {
        public string? Color { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"This Is a {GetType().Name}");
        }
    }

    class Circle : Shape
    {
        public void CircleColor()
        {
            Console.WriteLine($"This Circle Shape Color Is  {Color}");
        }
    }

    class Rectangle : Shape
    {
        public void RectangleColor()
        {
            Console.WriteLine($"This Rectangle Shape Color Is {Color}");
        }
    }
}

class HierarchicalInheritance
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Color = "Pink";
        circle.DisplayDetails();
        circle.CircleColor();

        Rectangle rec = new Rectangle();
        rec.Color = "Yellow";
        rec.DisplayDetails();
        rec.RectangleColor();
    }
}
