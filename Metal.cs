using System;

namespace ConsoleLabsOOP
{
    class Metal : Dish
    {
        public string Metal_Type { get; set; }

        /*#########################################*/

        public Metal()
        {
            Metal_Type = "Unknown";
        }

        public Metal(string _name, string _type) : base(_name)
        {
            Metal_Type = _type;
        }

        /*#########################################*/

        public string Old_or_New()
        {
            Random rnd = new Random();

            int a = rnd.Next(0, 2);

            if (a == 0) return "new";
            else return "old";
        }

        /*#########################################*/

        public override string Info()
        {
            string str =
                $"Class: Metal\n" +
                $"Name: {this.Name}\n" +
                $"Name length: {this.Name_Lenght()}\n" +
                $"Type of metal: {this.Metal_Type}\n" +
                $"Status: {this.Old_or_New()}";

            return str;
        }
    }
}
