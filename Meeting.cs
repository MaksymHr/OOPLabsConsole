namespace ConsoleLabsOOP
{
    class Meeting
    {
        private string date;
        private string theme;
        private int members;

        /*####################################################################################*/

        public Meeting()
        {
            this.date = "01/01/1970";
            this.theme = "Undefinded";
            this.members = 0;
        }

        public Meeting(string _date, string _theme, int _members)
        {
            this.date = _date;
            this.theme = _theme;
            this.members = _members;
        }

        /*####################################################################################*/

        public string Data
        {
            get { return date; }
            set { date = value; }
        }

        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }

        public int Members
        {
            get { return members; }
            set { members = value; }
        }

        /*####################################################################################*/

        public string Output()
        {
            return $"\nMeeting date: {this.date}\nMeeting theme: {this.theme}\nMeeting number of members: {this.members}\n";
        }
    }
}
