//Question-4

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
            Logger.setNameAndPassword("Ritik dixit", 8979);
            Logger.Login("Ritik dixit", 8979);

        }
    }

    public static class Logger
    {
        static string name;
        static int password;
        public static void setNameAndPassword(string username, int userpassword)
        {
            name = username;
            password = userpassword;
        }
        public static void Login(string username, int userpassword)
        {
            if (username == name && userpassword == password)
            {
                Console.WriteLine("Login SuccessFull");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Login Failed");
                Console.ReadKey();
            }
        }
    }

}