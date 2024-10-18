using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Ref_OutEx
{
    class OutExample
    {
        static void Main()
        {
            //Two Way to Declare The Parameters
            //int Num;
            //String text;

            //Calling The Function
            InitializeValue(out int Num, out string text);

            Console.WriteLine($"Number:- {Num}");
            Console.WriteLine($"String:- {text}");
        }

        static void InitializeValue(out int number, out string message)
        {
            //Assign The Integer Number And String Messge Using Out 
            number = 101;
            message = "Welcome To Code-Mind Technology";
        }
    }
}
