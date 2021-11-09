using System;

namespace ConsoleLabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish[] array = new Dish[8];

            array[0] = new Dish();
            array[1] = new Dish("Plate");

            array[2] = new Ceramic();
            array[3] = new Ceramic("Cup", 5);

            array[4] = new Metal();
            array[5] = new Metal("Thermos", "Aluminium");

            array[6] = new Flask();
            array[7] = new Flask("Flask", "Steel", "Green");

            for (int i = 0; i < 8; i++)
                Console.WriteLine($"{array[i].Info()}\n");

            return;
        }
    }
}
