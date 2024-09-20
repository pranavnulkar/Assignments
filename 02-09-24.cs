using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class _02_09_24
    {
        static void Main()
        {
            Console.WriteLine("Enter The Grade Points");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 100)
            {
                Console.WriteLine("Please Enter Grade Between 0-100");
            }
            else if (x < 0)
            {
                Console.WriteLine("Please Enter Positive Grade Between 0-100");
            }
            else if(x >= 90)
            {
                Console.WriteLine("The Letter Grade Is A");
            }
            else if (x >= 80)
            {
                Console.WriteLine("The Letter Grade Is B");
            }
            else if (x >= 70)
            {
                Console.WriteLine("The Letter Grade Is C");
            }
            else if (x >= 60)
            {
                Console.WriteLine("The Letter Grade Is D");
            }
            else if (x >= 40)
            {
                Console.WriteLine("The Letter Grade Is E");
            }           
            else
            {
                Console.WriteLine("The Grade Letter Is F");
            }
        }
    }
}
