using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignments.Delegates
{
    public delegate void Operation(int a, int b);

    class MathOperations
    {
        public void AddNum(int a, int b)
        {
            Console.WriteLine($"Addition Of Two Numbers:- {a + b}");
        }

        public void SubNum(int a, int b)
        {
            Console.WriteLine($"Subtraction Of Two Numbers:- {a - b}");
        }

        public void MulNum(int a, int b)
        {
            Console.WriteLine($"Multiplication Of Two Numbers:- {a * b}");
        }
    }

    class MulticastDelegate
    {
        static void Main()
        {
            // MathOperation class object
            MathOperations mo = new MathOperations();

            //create delegate instance
            //create delegete chain using += and pass the prameter
            Operation op = new Operation(mo.AddNum);
            op += mo.SubNum;
            op += mo.MulNum;

            op += (int a, int b) => Console.WriteLine($"Division of Two number Is:- {a / b}");

            op(10, 5);
        }

    }
}
