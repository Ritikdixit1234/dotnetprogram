//Question-9

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
            Car Audi = new Car("bmw");

        }

    }

    public sealed class Vechile
    {
        string vechile;
        public void startEngine(string vechile)
        {
            this.vechile = vechile;
            Console.WriteLine(vechile + " is start");
        }
        public void stopEngine()
        {

            Console.WriteLine(vechile + "is stop");
        }
    }

    public class Car : Vechile
    {
        string name;
        public Car(string name)
        {
            this.name = name;
        }
    }

}
