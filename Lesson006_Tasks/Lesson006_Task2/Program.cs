using System;
using System.Text;

namespace Lesson006_Task2
{
    class Program
    {
        static void LogicOr(int a, int b)
        {
            Console.WriteLine($"LogicOr = {a | b}");
        }
        static void LogicAnd(int a, int b)
        {
            Console.WriteLine($"LogicAnd = {a & b}");
        }
        static void Exclusion(int a, int b)
        {
            Console.WriteLine($"Exclusion = {a ^ b}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть два цілих числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть знак логічної операції:  ( |  &  ^ )");
            string act = Console.ReadLine();

            switch (act)
            {
                case ("|"):
                    {
                        LogicOr(a, b);
                        break;
                    }
                case ("&"):
                    {
                        LogicAnd(a, b);
                        break;
                    }
                case ("^"):
                    {
                        Exclusion(a, b);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неправильний знак!");
                        break;
                    }
            }
            }
    }
}
