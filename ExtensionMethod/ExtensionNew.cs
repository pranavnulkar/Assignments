using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExtensionMethod
{
    static class ExtensionNew
    {
        public static void Subtraction(this ExtensionOld eo)
        {
            int sub = eo.x - eo.y - eo.z;
            Console.WriteLine($"Subtraction Of Given Number Is:- {sub}");
        }

        public static void Multiplication(this ExtensionOld eo)
        {
            int mul = eo.x * eo.y * eo.z;
            Console.WriteLine($"Multiplication Of Given Number Is:- {mul}");
        }

        public static void Division(this ExtensionOld eo,int x,int y)
        {
            try
            {
                if (y == 0)
                {
                    throw new DivideByZeroException("Denominator Cannot be Zero");
                }
                double div = x / y;
                Console.WriteLine($"Division Of Given Number Is:- {div}");

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
