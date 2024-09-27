using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignments.OOPS
{
    class Person
    {
        public string Name { get; set; }
        public int Age {  get; set; }

        public Person(string Name,int Age) 
        {   
            this.Name = Name;
            this.Age = Age;
        }
    }

    class Student : Person
    {
        public int Roll_No { get; set; }
        public string? Address { get; set; }
        public int Mobile_No { get; set; }

        public Student(String Name,int Age,int roll_No, string? address, int mobile_No):base(Name,Age)
        {
            Roll_No = roll_No;
            Address = address;
            Mobile_No = mobile_No;
        }

        public void Display()
        {
            Console.WriteLine("Student Details Are");
            Console.WriteLine($" Name:- {Name} \n Age:- {Age} \n Roll No:- {Roll_No} \n Address:- {Address} \n Mobile:- {Mobile_No}");
        }
    }

    class SingleInheritance
    {
        static void Main()
        {
            Student stud = new Student("Pranav",25,101,"Pune",0123456789);
            //stud.Name = "Pranav";
            //stud.Age = 25;
            //stud.Roll_No = 101;
            //stud.Address = "Pune";
            //stud.Mobile_No = 1234567890;
            stud.Display();
        }
    }
}
