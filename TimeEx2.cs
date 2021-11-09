namespace ConsoleLabsOOP
{
    class TimeEx2
    {
        int hours;
        int minutes;
        int seconds;

        public TimeEx2()
        {
            hours = 0; minutes = 0; seconds = 0;
        }

        public TimeEx2(int a, int b, int c)
        {
            hours = a; minutes = b; seconds = c;

            while (seconds >= 60)
            {
                minutes++; seconds -= 60;
            }
            while (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            while (hours >= 24)
            {
                hours -= 24;
            }
        }

        public int ToMidnight()
        {
            return 24 * 60 - (hours * 60 + minutes);
        }

        public void Plus100()
        {
            minutes += 100;
            while (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
        }

        public string CurTime(string str = "")
        {
            str = $"Time: {hours}:{minutes}:{seconds}";
            return str;
        }
    }
}
