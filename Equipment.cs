namespace ConsoleLabsOOP
{
    class Equipment : Item
    {
        int condition;
        public int Condition
        {
            get { return condition; }
            set
            {
                if (value < 0) condition = 0;
                else if (value > 100) condition = 100;
                else condition = value;
            }
        }

        public Equipment()
        {
            Condition = 0;
        }

        public Equipment(string _name, int _price, double _mass, int _cond) : base(_name, _price, _mass)
        {
            Condition = _cond;
        }

        public virtual string Condition_str()
        {
            if (this.Condition < 30) return "Bad";
            else if (this.Condition < 60) return "Average";
            else return "Good";
        }

        public override int NameLength()
        {
            return this.Name.Length;
        }

        public override string Info()
        {
            string str = $"Class: EQUIPMENT\n{base.Info()}";
            str += $"\nEquipment condition: {this.Condition}%\n";
            str += $"Condition: {this.Condition_str()}\n" +
                $"Name length: {this.NameLength()}\n";
            return str;
        }
    }
}
