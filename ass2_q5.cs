//Question-5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public partial class Person
    {
        public string firstName;
        public string lastName;
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public partial class Person
    {
        public void showDetails()
        {

            Console.WriteLine("FirstName :" + firstName + "LastName :" + lastName);
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("ritik", "dixit");
            p1.showDetails();

        }

    }

}