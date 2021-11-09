using System;

namespace ConsoleLabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            string Number = Console.ReadLine();

            Console.Write("Input number a: ");
            string a = Console.ReadLine();

            bool answer = Number.Contains(a);

            if (a.Length == 1)
            {
                if (answer) Console.WriteLine($"Number {Number} contain number {a}.");
                else Console.WriteLine($"Number {Number} not contain number {a}.");
            }
            else
            {
                Console.WriteLine("Number a must be 1 symbol. Try again.");
            }

            return;
        }
    }
}
