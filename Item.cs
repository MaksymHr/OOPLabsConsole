namespace ConsoleLabsOOP
{
    abstract class Item
    {
        int price;
        double mass;
        public string Name { get; set; }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0) price = 0;
                else price = value;
            }
        }
        public double Mass
        {
            get { return mass; }
            set
            {
                if (value < 0) mass = 0.0;
                else mass = value;
            }
        }

        public Item()
        {
            Name = "Unknown";
            Price = 0;
            Mass = 0;
        }

        public Item(string _name, int _price, double _mass)
        {
            Name = _name;
            Price = _price;
            Mass = _mass;
        }

        public virtual string Info()
        {
            string _mass = "";

            if (this.Mass > 1000)
                _mass += $"{this.Mass / 1000}kg";
            else
                _mass += $"{this.Mass}g";

            string str =
                $"Main info:\n" +
                $"Name: {this.Name}\n" +
                $"Price: {this.Price}$\n" +
                $"Mass: {_mass}";

            return str;
        }
    }
}