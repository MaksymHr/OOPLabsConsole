using System;

namespace ConsoleLabsOOP
{
    class Conference
    {
        private string name;
        private string place;
        private Meeting[] meetings;

        /*####################################################################################*/

        public Conference()
        {
            name = "Undefinded";
            place = "Undefinded";
        }

        public Conference(string _name, string _place)
        {
            this.name = _name;
            this.place = _place;
        }

        public Conference(string _name, string _place, Meeting[] _meetings)
        {
            this.name = _name;
            this.place = _place;
            this.meetings = new Meeting[_meetings.Length];
            for (int i = 0; i < _meetings.Length; i++)
                this.meetings[i] = _meetings[i];
        }

        /*####################################################################################*/

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public Meeting[] Meetings
        {
            get { return meetings; }
            set
            {
                this.meetings = new Meeting[value.Length];

                for (int i = 0; i < this.meetings.Length && i < value.Length; i++)
                    this.meetings[i] = value[i];
            }
        }

        /*####################################################################################*/

        public double Average_Meeting_Members()
        {
            double sum = 0;

            for (int i = 0; i < this.meetings.Length; i++)
                sum += this.meetings[i].Members;

            return Math.Round(sum / this.meetings.Length, 2);
        }

        public int Biggest_meeting()
        {
            int max = meetings[0].Members;
            int imax = 0;

            for (int i = 0; i < meetings.Length; i++)
            {
                if (meetings[i].Members > max)
                {
                    max = meetings[i].Members;
                    imax = i;
                }
            }

            return imax;
        }

        public int Name_Length()
        {
            return this.name.Length;
        }

        /*####################################################################################*/

        public string Output()
        {
            string str = $"\nConference name: {this.name};\nConference place: {this.place}.\n";

            foreach (Meeting meet in meetings)
                str += meet.Output();

            str += $"\nAverage members number: {Average_Meeting_Members()}\n";

            str += $"\nBiggest meeting: {this.meetings[Biggest_meeting()].Output()}\n";

            str += $"Length of name: {this.Name_Length()} characters";

            return str;
        }
    }
}
