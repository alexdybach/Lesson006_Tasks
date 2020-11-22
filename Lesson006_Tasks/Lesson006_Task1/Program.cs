using System;

namespace Lesson006_Task1
{
    class Program
    {
        static void CalculateIncrement(ref int a)
        {
            Console.WriteLine($"Increment = {++a}");
        }
        static void CalculateDecrement(ref int a)
        {
            Console.WriteLine($"Decrement = {--a}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int number = int.Parse(Console.ReadLine());
            CalculateIncrement(ref number);
            Console.WriteLine($"number: {number}");

            CalculateDecrement(ref number);
            Console.WriteLine($"number: {number}");

        }
    }
}
