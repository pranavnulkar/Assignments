using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExtensionMethod
{
    class ExtensionMain
    {
        static void Main()
        {
            //create object of old Class
            ExtensionOld extensionOld = new ExtensionOld();
            extensionOld.Addition();

            //calling method from new class using old class object
            extensionOld.Subtraction();
            extensionOld.Multiplication();
            extensionOld.Division(20,10);
        }
    }
}
