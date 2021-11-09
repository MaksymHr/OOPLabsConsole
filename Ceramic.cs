namespace ConsoleLabsOOP
{
    class Ceramic : Dish
    {
        private int hardness_coefficient;

        /*#########################################*/

        public Ceramic()
        {
            hardness_coefficient = -1;
        }

        public Ceramic(string _name, int _coef) : base(_name)
        {
            hardness_coefficient = _coef;
        }

        /*#########################################*/

        int Hardness_Coefficient
        {
            get { return hardness_coefficient; }
            set
            {
                if (value <= 0)
                    hardness_coefficient = 0;
                else if (value >= 100)
                    hardness_coefficient = 100;
                else
                    hardness_coefficient = value;
            }
        }

        /*#########################################*/

        public int Breakdown_Chance()
        {
            if (Hardness_Coefficient != -1)
                return 100 - Hardness_Coefficient;
            else
                return -1;
        }

        /*#########################################*/

        public override string Info()
        {
            string str =
                $"Class: Ceramic\n" +
                $"Name: {this.Name}\n" +
                $"Name lenght: {this.Name_Lenght()}\n" +
                $"Hardness coeff: {this.Hardness_Coefficient}\n" +
                $"Breakdown chance: {this.Breakdown_Chance()}%";

            return str;
        }
    }
}
