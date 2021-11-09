using System;

namespace ConsoleLabsOOP
{
    class Flask : Metal
    {
        string Color { get; set; }

        /*#########################################*/

        public Flask()
        {
            this.Color = "Unknown";
        }

        public Flask(string _name, string _type, string _color) : base(_name, _type)
        {
            this.Color = _color;
        }

        /*#########################################*/

        public bool For_Army()
        {
            Random rnd = new Random();

            rnd.Next(0, 2);

            if (rnd.Next(0, 2) == 0)
                return true;
            else
                return false;
        }

        /*#########################################*/

        public override string Info()
        {
            string str =
                $"Class: Flask\n" +
                $"Name: {this.Name}\n" +
                $"Name length: {this.Name_Lenght()}\n" +
                $"Type of metal: {this.Metal_Type}\n" +
                $"Status: {this.Old_or_New()}\n" +
                $"Color: {this.Color}\n" +
                $"For army: {this.For_Army()}";

            return str;
        }
    }
}
