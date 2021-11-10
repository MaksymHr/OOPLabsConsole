using System;

namespace ConsoleLabsOOP
{
    class Auto : IGlobal
    {
        double engineVolume;
        public string Brand { get; set; }
        public string Model { get; set; }
        public double EngineVolume
        {
            get { return engineVolume; }
            set
            {
                if (value < 0) engineVolume = 0.1;
                else engineVolume = value;
            }
        }
        public DateTime ReleaseDate { get; set; }

        public Auto(string _brand, string _model, double _volume, DateTime _date)
        {
            Brand = _brand;
            Model = _model;
            EngineVolume = _volume;
            ReleaseDate = _date;
        }
        public Auto(string _brand, string _model, double _volume, string _date)
        {
            Brand = _brand;
            Model = _model;
            EngineVolume = _volume;
            ReleaseDate = DateTime.Parse(_date);
        }
        public Auto()
        {
            Brand = "Unknown";
            Model = "Unknown";
            EngineVolume = 0;
            ReleaseDate = DateTime.MinValue;
        }

        public void Input()
        {
            Console.WriteLine("Please, input information for Auto:");
            Console.Write("Brand: ");
            this.Brand = Console.ReadLine();

            Console.Write("Model: ");
            this.Model = Console.ReadLine();

            Console.Write("Engine volume: ");
            this.EngineVolume = Convert.ToDouble(Console.ReadLine());

            Console.Write("Release date (d/m/y): ");
            this.ReleaseDate = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine();

            return; 
        }
        public void Output()
        {
            Console.WriteLine(
                $"Main info:\n" +
                $"Class: Auto\n" +
                $"Brand: {this.Brand}\n" +
                $"Model: {this.Model}\n" +
                $"Engine volume: {this.EngineVolume} L\n" +
                $"Release date: {this.ReleaseDate.ToLongDateString()}\n" +
                $"Operating time: {this.Processing()} years\n"
                );
        }
        public double Processing() 
        {
            DateTime now = DateTime.Today;
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = now - ReleaseDate;
            int years = (zeroTime + span).Year - 1;
            return Convert.ToDouble(years);
        }
    }
}
