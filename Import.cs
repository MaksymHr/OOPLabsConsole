namespace ConsoleLabsOOP
{
    class Import : Device
    {
        double length;
        double height;
        double width;

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0) length = -1;
                else length = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0) height = -1;
                else height = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0) width = -1;
                else width = value;
            }
        }
        public int Warranty { get; set; }

        public Import()
        {
            Length = 0;
            Height = 0;
            Width = 0;
            Warranty = 0;
        }

        public Import(string _name, int _price, double _mass, string _status, double _length, double _height, double _width, int _warranty) :
            base(_name, _price, _mass, _status)
        {
            Length = _length;
            Height = _height;
            Width = _width;
            Warranty = _warranty;
        }

        public override string Info()
        {
            string str = base.Info();
            str +=
                $"Sizes: {this.Length}mm/{this.Height}mm/{this.Width}mm\n" +
                $"Warranty term: {this.Warranty} month\n";
            return str;
        }
    }
}
