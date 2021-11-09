namespace ConsoleLabsOOP
{
    class Dish
    {
        public string Name { get; set; }

        /*#########################################*/

        public Dish()
        {
            Name = "Unknown";
        }

        public Dish(string _name)
        {
            Name = _name;
        }

        /*#########################################*/

        public int Name_Lenght()
        {
            return Name.Length;
        }

        /*#########################################*/

        public virtual string Info()
        {
            string str =
                $"Class: Dish\n" +
                $"Name: {this.Name}\n" +
                $"Name Lenght: {this.Name_Lenght()}";

            return str;
        }
    }
}
