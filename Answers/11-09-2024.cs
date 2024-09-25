using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    public class Person
    {
        protected int empId;
        protected string? empName;
        protected int empAge;
        protected string? empAddress;
    }

    public class Employee : Person
    {
        public Employee(int empId, string empName, int empAge, string empAddress)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
            this.empAddress = empAddress;
        }

        public void Display()
        {
            Console.WriteLine("Employee Details\n");
            Console.WriteLine($" Id:- {empId} \n Name:- {empName} \n Age:- {empAge} \n Address:- {empAddress}");
        }
    }


    //Private Acess Modifier
    public class Person1
    {
        private string? firstName;
        private string? lastName;

        public void empName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Display1()
        {
            Console.WriteLine($"\n Employee Full Name Is:- {firstName}  {lastName}");
        }
    }

    class _11_09_2024
    {
        static void Main()
        {
            Employee emp = new Employee(101, "Pranav", 30, "Sangli");
            emp.Display();
            Employee emp1 = new Employee(102, "Ajit", 35, "Nagar");
            emp1.Display();

            Person1 p1 = new Person1();
            p1.empName("Pranav", "Nulkar");
            p1.Display1();
        }
    }
}
