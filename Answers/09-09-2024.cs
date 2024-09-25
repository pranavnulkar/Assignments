using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    class _09_09_2024
    {
        static void Main()
        {
            /*int[] arr = { 50, 30, 80, 10, 40 };
            Console.Write("Your Given Array Is : ");
            foreach (var num in arr)
            {
                Console.Write($"{num} \t");
            }

            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"\nMaximum Value In Given Array Is : {max}");
            Console.WriteLine($"Minimum Value In Given Araay Is : {min}"); */



            //String Array For Searching The Name In The Array
            /*string[] name = { "Alice", "Bob", "Charlie", "David", "Emily" };
            Console.WriteLine("Given String Array Is : ");
            foreach (string s in name)
            {
                Console.WriteLine(s + "\t");
            }

            Console.WriteLine("\nEnter Name Got Be Search In The Array");
            string x = Console.ReadLine().ToString();
            string present="";
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == x)
                {
                    present = name[i];
                }
            }
            if (present == x)
            {
                Console.WriteLine($"{x} Is Present In Array");
            }
            else
            {
                Console.WriteLine($"{x} Is Not Present In Array");
            }*/

            //stringbuilder Operations
            StringBuilder sb = new StringBuilder();

            sb.Append("Hi Guys\n");
            sb.Append("David");
            sb.Append(",");
            sb.Append("Kane");
            sb.Append(",");
            sb.Append("Barvo");
            sb.Append(",");
            sb.Append("Steve");
            sb.Append(",");
            sb.Append("Shane");

            string x = sb.ToString();
            Console.WriteLine($"Original String Using Append Operation: \n {x}");

            Console.WriteLine();
            sb.Replace("Hi Guys", "Hello Team");
            string x1 = sb.ToString();
            Console.WriteLine($"After Rplace Operation The String Is: \n {x1}");

            Console.WriteLine();
            sb.Remove(5, 5);
            string x2 = sb.ToString();
            Console.WriteLine($"After Remove Operation The String Is: \n {x2}");
        }
    }
}
