////Problem 7. Timer
////Using delegates write a class Timer that can execute certain method at each t seconds

////Problem 8.* Events
////Read in MSDN about the keyword event in C# and how to publish events.
////Re-implement the above using .NET events and following the best practices.
namespace TimerDelegate
{
    using System;
    using System.Timers;

    public delegate void CallMethod(int second);

    public class TimerDelegate
    {
        public static void CallMethodAtTSeconds(int seconds)
        {
            var timer = new Timer(seconds * 1000);
            timer.Elapsed += RunThis;
            timer.AutoReset = true;
            timer.Enabled = true;
            Console.ReadLine();
        }

        private static void RunThis(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("The curent time is: " + e.SignalTime.ToLongTimeString());
        }
    }
}