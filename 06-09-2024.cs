using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class _06_09_2024
    {
        static void Main()
        {
            //string s = "CODEMIND TECHNOLOGY";
            //string reverse = Reverse(s);

            //Console.WriteLine("Original String Is :- " +s);
            //Console.WriteLine("Reversed String Is :- " +reverse);

            // static string Reverse(string str)
            //{
            //    //empty String
            //    string revString = "";

            //    //Append Each Character In String
            //    for (int i = str.Length-1; i >= 0; i--)
            //    {
            //        revString += str[i];
            //    }
            //    return revString;
            //}



            //Find Even Or Odd In The Array
            Console.WriteLine("Enter The Size OF Array Element");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] Numbers = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter The Array Element {i + 1}:-");
                int y = Convert.ToInt32(Console.ReadLine());
                Numbers[i] = y;
            }
            //Display All Element In Array
            Console.WriteLine("");
            Console.WriteLine("===You Entered Element In Array ===");
            Print(Numbers);
            Console.WriteLine();

            static void Print(int[] arr)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + "\t");
                }
            }

            int[] even = new int[Numbers.Length];
            int[] odd = new int[Numbers.Length];
            int evencnt = 0;
            int oddcnt = 0;

            foreach (int number in Numbers)
            {

                if (number % 2 == 0)
                {
                    even[evencnt++] = number;
                }
                else
                {
                    odd[oddcnt++] = number;
                }
            }

            Console.WriteLine("Even Numbers Is:- ");
            for(int i = 0; i < evencnt; i++)
            {
                Console.Write(even[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd Numbers Is :- ");
            for(int i = 0; i < oddcnt; i++)
            {
                Console.Write(odd[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
