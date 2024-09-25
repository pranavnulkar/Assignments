using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    class _18_09_2024
    {
        static void Main()
        {
            Console.WriteLine("How Many Element In Array");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] Numbers = new int[x];
            //Accept the numbers From User
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"Enter {i + 1} No Elements:- ");
                int y = Convert.ToInt32(Console.ReadLine());
                Numbers[i] = y;
            }

            //To Print All Numbers In Array 
            Console.WriteLine("Your Entered Element In Array :- ");
            foreach (var num in Numbers)
            {
                Console.Write(num + "\t");
            }

            //To Print The Alternate Number In Array
            Console.WriteLine("\nAlternate Numbers In Array:-");
            for (int i = 0; i < Numbers.Length; i += 2)
            {
                Console.Write(Numbers[i] + "\t");
            }

            //To Print Number Count In Array
            //Small And Big Number In Array
            int count = 0;
            int min = Numbers[0];
            int max = Numbers[0];
            for (int i = 0; i < Numbers.Length; i++)
            {
                count++;
                if (Numbers[i] < min)
                {
                    min = Numbers[i];
                }
                else if (Numbers[i] > max)
                {
                    max = Numbers[i];
                }
            }
            Console.WriteLine("\nTotal Number Count In Given Array Is :- " + count);
            Console.WriteLine("Minimum Number In Given Array Is :- " + min);
            Console.WriteLine("Maximum Number In Given Array Is :- " + max);
        }
    }
}
