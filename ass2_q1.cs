//Question-1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(77, "Ritik dixit", 50000.00);
            e1.displayData();
        }
    }
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void displayData()
        {
            Console.WriteLine("id :" + this.id);
            Console.WriteLine("Name :" + this.name);
            Console.WriteLine("Salary :" + this.salary);
            Console.ReadKey();
        }
    }
} 