using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Ref_OutEx
{       
    class RefExample
    {
        static void IncrementNum(ref int a)
        {
            a++;
        }

        static void Main()
        {
            int x = 10;
            Console.WriteLine($"Before Increment Value of x Is:- {x}");
            //passing value of x to method using ref
            IncrementNum(ref x);
            Console.WriteLine($"After Increment Value Of x Is:- {x}");
        }
    }
}
