using System;

namespace ConsoleLabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write($"Please, input conference name: ");
            string name = Console.ReadLine();

            Console.Write($"Please, input conference place: ");
            string place = Console.ReadLine();

            Conference conference = new Conference(name, place);

            Meeting[] meetings = new Meeting[3];

            for (int i = 0; i < 3; i++)
                meetings[i] = new Meeting($"{rnd.Next(0, 30)}/{rnd.Next(0, 12)}/{rnd.Next(2000, 2050)}", $"{conference.Name} #{i + 1}", rnd.Next(0, 100)); // yes, i know, its badcode

            conference.Meetings = meetings;

            Console.WriteLine($"{conference.Output()}\n");

            return;
        }
    }
}
