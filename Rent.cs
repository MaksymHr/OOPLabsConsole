using System;

namespace ConsoleLabsOOP
{
    class Rent : IGlobal
    {
        int numberOfRooms;
        int totalArea;
        int price;
        public string Address { get; set; }
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set
            {
                if (value < 0) numberOfRooms = 0;
                else numberOfRooms = value;
            }
        }
        public int TotalArea
        {
            get { return totalArea; }
            set
            {
                if (value < 0) totalArea = 0;
                else totalArea = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0) price = 0;
                else price = value;
            }
        }

        public Rent(string _address, int _rooms, int _area, int _price)
        {
            Address = _address;
            NumberOfRooms = _rooms;
            TotalArea = _area;
            Price = _price;
        }
        public Rent()
        {
            Address = "Unknown";
            NumberOfRooms = 0;
            TotalArea = 0;
            Price = 0;
        }

        public double Processing()
        {
            return this.Price / this.TotalArea;
        }

        public void Input()
        {
            Console.WriteLine("Please, input info for Rent:");

            Console.Write("Appartments address: ");
            this.Address = Console.ReadLine();

            Console.Write("Number of rooms: ");
            this.NumberOfRooms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Total area: ");
            this.TotalArea = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rental cost: ");
            this.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            return;
        }

        public void Output()
        {
            Console.WriteLine(
                $"Main info:\n" +
                $"Class: Rent\n" +
                $"Address: {this.Address}\n" +
                $"Number of Rooms: {this.NumberOfRooms}\n" +
                $"Total area: {this.TotalArea} m^2\n" +
                $"Rental const: {this.Price} hrn\n" +
                $"Cost for m^2: {this.Processing()} hrn\n"
                );
            return;
        }

    }
}
