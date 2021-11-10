using System;

namespace ConsoleLabsOOP
{
    class Tovar : IGlobal
    {
        const double Course = 26.1;
        double price;

        public string ProductName { get; set; }
        public string ShopName { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) price = 0;
                else price = value;
            }
        }
        
        public Tovar()
        {
            ProductName = "Unknown";
            ShopName = "Unknown";
            Price = 0;
        }

        public Tovar(string _prod, string _shop, int _price)
        {
            ProductName = _prod;
            ShopName = _shop;
            Price = _price;
        }

        public double Processing()
        {
            return Math.Round(this.Price / Course, 2);
        }

        public void Input()
        {
            Console.WriteLine("Please, input info for Tovar:");
            
            Console.Write("Name of Product: ");
            this.ProductName = Console.ReadLine();

            Console.Write("Name of Shop: ");
            this.ShopName = Console.ReadLine();

            Console.Write("Price of Product: ");
            this.Price = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();

            return;
        }

        public void Output()
        {
            Console.WriteLine(
                $"Main info:\n" +
                $"Class: Tovar\n" +
                $"Name of product: {this.ProductName}\n" +
                $"Name of shop: {this.ShopName}\n" +
                $"Price (hrn): {this.Price}hrn\n" +
                $"Price ($): {this.Processing()}$\n"
                );
            return;
        }
    }
}
