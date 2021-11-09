namespace ConsoleLabsOOP
{
    class Device : Item
    {
        public string Status { get; set; }

        public Device()
        {
            Status = "Unknown";
        }

        public Device(string _name, int _price, double _mass, string _status) : base(_name, _price, _mass)
        {
            Status = _status;
        }

        public virtual string PriceCheck()
        {
            if (this.Price > 500)
                return "Expensively";
            else
                return "Cheap";
        }

        public override string Info()
        {
            string str = $"Class: DEVICE\n{base.Info()}";
            str += $"\nStatus: {this.Status}\n";
            str += $"Price info: {this.PriceCheck()}\n";
            return str;
        }
    }
}
