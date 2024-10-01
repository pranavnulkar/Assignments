using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPS
{
    class Persons
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public void Intro()
        {
            Console.WriteLine($"My Name Is {Name} And I Am {Age} Years Old");
        }
    }

    class Teacher : Persons
    {
        public string? Subject { get; set; }

        public void TecherIntro()
        {
            Console.WriteLine($"I am Teching A {Subject} Subject");
        }
    }

    class Principle : Teacher
    {
        public string? SchoolName { get; set; }

        public void PrincipleIntro()
        {
            Console.WriteLine($"I am {Name} I am Teaching a {Subject} subject And Principle Of {SchoolName}");
        }
    }


    class MultilevelInheritance
    {
        static void Main()
        {
            Principle p = new Principle();
            p.Name = "Pranav";
            p.Age = 25;
            p.Subject = "C#";
            p.SchoolName = "Orchid Public School";
            p.Intro();
            p.TecherIntro();
            p.PrincipleIntro();
        }
    }
}
