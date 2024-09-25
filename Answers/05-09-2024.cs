using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    internal class _05_09_2024
    {
        static void Main()
        {
            //Array
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


            //Calculate Sum AOf All Element By SumArr Method
            Console.WriteLine("\n=== Sum Of All Elements In Array ===");
            Console.WriteLine("---------- " + SumArr(Numbers) + " ----------");

            //Calculate Average Of Array Element
            Console.WriteLine();
            Console.WriteLine("\n=== Average Of Array Is ===");
            double average = (double)SumArr(Numbers) / x;
            Console.WriteLine("---------- " + average + " ----------");
        }
        //Print Method
        public static void Print(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + "\t");
            }
        }
        //Sum Method
        public static int SumArr(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }
}
