using System;

namespace ConsoleLabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1.");
            Console.Write("Input minutes: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Time time = new Time(a, b);

            Console.WriteLine($"{time.Format()}");
            Console.WriteLine($"We have {time.Count_of_Seconds()} seconds.");

            Console.WriteLine("Exercise 2.");
            Console.Write("Input hours: ");
            int a0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            int b0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds: ");
            int c = Convert.ToInt32(Console.ReadLine());

            TimeEx2 time0 = new TimeEx2(a, b, c);

            Console.WriteLine($"{time0.CurTime()}");
            Console.WriteLine($"To midnight {time0.ToMidnight()} minutes.");

            time0.Plus100();
            Console.WriteLine($"{time0.CurTime()}");

            return;
        }
    }
}
