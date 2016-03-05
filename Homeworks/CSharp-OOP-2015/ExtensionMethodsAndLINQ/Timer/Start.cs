namespace TimerDelegate
{

    public class Start
    {
        public static void Main()
        {
            var td = new CallMethod(TimerDelegate.CallMethodAtTSeconds);
            td(1);
        }
    }
}