namespace MobilePhone
{
    using System;
    using System.Timers;

    public class Call
    {
        public Call(string calledNumber, int duration)
        {
            this.CalledNumber = calledNumber;
            this.Duration = duration;
            this.DateAndTime = DateTime.Now;
        }

        public DateTime DateAndTime { get; private set; }

        public string CalledNumber { get; private set; }

        public int Duration { get; private set; }
    }
}
