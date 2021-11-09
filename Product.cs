using System;

namespace ConsoleLabsOOP
{
    class Product : Item
    {
        public int implementationPeriod { get; set; }

        public Product()
        {
            implementationPeriod = 0;
        }

        public Product(string _name, int _price, double _mass, int _imp) : base(_name, _price, _mass)
        {
            implementationPeriod = _imp;
        }

        public virtual string End_of_Realization()
        {
            DateTime date = DateTime.Today;
            date = date.AddMonths(this.implementationPeriod);
            return date.ToShortDateString();

        }

        public override int NameLength()
        {
            return this.Name.Length;
        }

        public override string Info()
        {
            string str = $"Class: PRODUCT\n{base.Info()}";
            str += $"\nImplementation Period: {this.implementationPeriod} month\n";
            str += $"End of realization: {this.End_of_Realization()}\n" +
                $"Name Length: {this.NameLength()}\n";
            return str;
        }
    }
}
