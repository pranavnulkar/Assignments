using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExtensionMethod
{
    class ExtensionOld
    {
        public int x = 40,y=10,z=20;

        public void Addition()
        {
            int add = x + y + z;
            Console.WriteLine($"Additio Of Given Number Is:- {add}");
        }
    }
}
