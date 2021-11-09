using System;

namespace ConsoleLabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] array = new Item[8];

            array[0] = new Device();
            array[1] = new Device("Phone", 300, 120, "On Work");

            array[2] = new Import();
            array[3] = new Import("Tablet", 550, 360, "Broken", 150, 100, 15, 12);

            array[4] = new Product();
            array[5] = new Product("Lamp", 15, 50, 12);

            array[6] = new Equipment();
            array[7] = new Equipment("Tool", 5000, 15000, 48);

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(array[i].Info());
                Console.ForegroundColor = (ConsoleColor)4;
                Console.WriteLine("############################################################\n");
                Console.ForegroundColor = (ConsoleColor)7;
            }

            return;
        }
    }
}
