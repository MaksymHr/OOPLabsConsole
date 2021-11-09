using System;

namespace ConsoleLabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input size of matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Matrix matrix = new Matrix(n);

            Console.WriteLine($"\nMatrix: ");
            matrix.Print(n);

            matrix.Change(n);

            Console.WriteLine("\nNew matrix: ");
            matrix.Print(n);

            return;
        }
    }
}