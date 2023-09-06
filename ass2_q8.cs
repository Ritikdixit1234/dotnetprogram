//Question-8

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
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            d1.Sound("WOW WOW");
            c1.Sound("MEOW MEOW");
        }

    }

    public abstract class Animal
    {
        public abstract void Sound(string sound);
    }
    public class Dog : Animal
    {
        public override void Sound(string sound)
        {
            Console.WriteLine("Dog sound " + sound);
            Console.ReadKey();
        }
    }
    public class Cat : Animal
    {
        public override void Sound(string sound)
        {
            Console.WriteLine("Cat Sound " + sound);
            Console.ReadKey();
        }

    }


}