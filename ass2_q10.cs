
//Question-10

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


        }

        sealed class Bank
        {
            public int AccountNumber;
            public string name;
            public double balance;

            public Bank(int AccountNumber, string name, double balance)
            {
                this.AccountNumber = AccountNumber;
                this.name = name;
                this.balance = balance;
            }
            public void deposit(double balance)
            {
                balance += balance;
            }
            public void withdrawl(double amount)
            {
                if (amount > balance)
                {
                    Console.WriteLine("Insufficinent Balance");
                }
                else
                {
                    balance = balance - amount;
                }
            }
            public void displayData()
            {
                Console.WriteLine("AccountNumber:" + this.AccountNumber);
                Console.WriteLine("Name :" + this.name);
                Console.WriteLine("Balance :" + this.balance);
                Console.ReadKey();
            }
        }
        class SavingAccount : Bank
        {
            public int AccountNumber;
            public string name;

        }
    }

}

