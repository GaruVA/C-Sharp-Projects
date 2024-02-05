using DigitalClock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Clock clock = new Clock();
while (true)
{
    clock.UpdateTime();
    Console.Clear();
    Console.WriteLine($"Time: {clock.Hours:D2}:{clock.Minutes:D2}:{clock.Seconds:D2}");
    Thread.Sleep(1000);
}

namespace DigitalClock
{
    class Clock
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public void UpdateTime()
        {
            DateTime now = DateTime.Now;
            Hours = now.Hour;
            Minutes = now.Minute;
            Seconds = now.Second;
        }
    }
}
