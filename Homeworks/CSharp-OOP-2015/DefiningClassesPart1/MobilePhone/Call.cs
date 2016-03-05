namespace MobilePhone
{
    using System;
    using System.Timers;

    public class Call
    {
        public Call(DateTime date, DateTime time, string calledNumber, double duration)
        {
            this.Date = date;
            this.Time = time;
            this.CalledNumber = calledNumber;
            this.Duration = duration;
        }

        public DateTime Date { get ; private set; }

        public DateTime Time { get; private set; }

        public string CalledNumber { get; private set; }

        public double Duration { get; private set; }
    }
}
