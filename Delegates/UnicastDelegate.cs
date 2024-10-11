using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignments.Delegates
{
    public delegate int AddDel(int a, int b);
    public delegate int SubDel(int a, int b);

    class OperationDel
    {
        public int AddNum(int a, int b)
        {
            return a + b;
        }

        public int SubNum(int a, int b)
        {
            return a - b;
        }
    }
    class UnicastDelegate
    {
        static void Main()
        {
            OperationDel od = new OperationDel();

            AddDel ad = new AddDel(od.AddNum);
            int x =ad(50, 70);
            Console.WriteLine($"Addition Of Two Number Is:- {x}");

            SubDel sd = new SubDel(od.SubNum);
            int y = sd(200, 120);
            Console.WriteLine($"Subtraction Of Two Numbers Is:- {y}");
        }
    }
}
