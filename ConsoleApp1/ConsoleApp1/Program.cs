using System;
using FizzBuzzNamespace;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //array to hold the fizzbuzz sequence calculated by FizzBuzzClass
            string[] sequence;

            sequence = FizzBuzzClass.Calculate();

            //printing out the sequence
            foreach(string i in sequence)
            {
                Console.WriteLine(i);
            }

            //pausing
            Console.Read();
        }
    }
}
