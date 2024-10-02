using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Collections
{
    internal class ArrayListNonGenerics
    {
        static void Main()
        {
            //Object Of array List
            ArrayList arraylst = new ArrayList();
            arraylst.Add(101);
            arraylst.Add(true);
            arraylst.Add(false);
            arraylst.Add("A");
            arraylst.Add("Good Morning");
            arraylst.Add(10.10D);
            arraylst.Add(2500L);
            arraylst.Add(2.99F);
            arraylst.Add("P");
            arraylst.Add(25000L);

            Console.WriteLine("ArrayList Element:-");
            foreach (var list in arraylst)
            {
                Console.WriteLine(list);
            }

            //Arraylist Operations
            arraylst.Remove(true);
            arraylst.RemoveAt(5);
            arraylst.RemoveRange(0, 2);
            arraylst.Reverse();

            Console.WriteLine("Arraylist After Applying Arraylist Operations");
            foreach(var list in arraylst)
            {
                Console.WriteLine(list);
            }
        }

    }
}
