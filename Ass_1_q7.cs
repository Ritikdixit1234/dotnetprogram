PROGRAM 7-
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter Elements to be search");
            int n = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Element found at index :" + i);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Element not found");
            Console.ReadLine();

        }
    }
}