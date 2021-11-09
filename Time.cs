namespace ConsoleLabsOOP
{
    class Time
    {
        private int minutes;
        private int seconds;

        public Time(int a = 0, int b = 0)
        {
            minutes = a; seconds = b;

            while (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }
        }

        public string Format(string str = "")
        {
            str = $"We have {minutes} minutes and {seconds} seconds.";
            return str;
        }

        public int Count_of_Seconds()
        {
            return minutes * 60 + seconds;
        }
    }
}
