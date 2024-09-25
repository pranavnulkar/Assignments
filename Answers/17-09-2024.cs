using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    class _17_09_2024
    {
        static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            Console.WriteLine("The Given Array Is :-");
            foreach (var s in nums)
            {
                Console.Write(s + "\t");
            }

            //To Find Prime Number In Given Array
            Console.WriteLine("\nPrime Numbers In Given Array Is :-");
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                for (int j = 2; j < nums[i]; j++)
                {
                    if (nums[i] % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && nums[i] >= 2)
                {
                    Console.Write(nums[i] + "\t");
                }
            }
        }
    }
}
