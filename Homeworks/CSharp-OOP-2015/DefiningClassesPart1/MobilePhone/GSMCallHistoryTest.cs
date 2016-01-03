namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSMCallHistoryTest
    {
        public static void StartGSMCallHistoryTest()
        {
            Console.WriteLine("Testing the GSM call history:\n");
            var testCallHistoryOfGSM = new GSM("8800", "Nokia");
            testCallHistoryOfGSM.AddCall(new Call("0886123456", 120));
            testCallHistoryOfGSM.AddCall(new Call("0887234567", 180));
            testCallHistoryOfGSM.AddCall(new Call("0888345678", 240));
            testCallHistoryOfGSM.AddCall(new Call("0889456789", 300));
            testCallHistoryOfGSM.PrintCallHistory();
            Console.WriteLine("Total price of the calls in the history: {0}", testCallHistoryOfGSM.PriceOfCalls(0.36m));
            int longestCallIndex = 0;
            for (int i = 1; i < testCallHistoryOfGSM.CallHistory.Count; i++)
            {
                if (testCallHistoryOfGSM.CallHistory[i].Duration > testCallHistoryOfGSM.CallHistory[longestCallIndex].Duration)
                {
                    longestCallIndex = i;
                }
            }

            Console.WriteLine("\nRemoving the call with longest duration:");
            testCallHistoryOfGSM.PrintCallInfo(longestCallIndex);
            testCallHistoryOfGSM.DeleteCall(testCallHistoryOfGSM.CallHistory[longestCallIndex]);
            Console.WriteLine("\nTotal price of the calls in the history after removing the longest call: {0}", testCallHistoryOfGSM.PriceOfCalls(0.36m));
            testCallHistoryOfGSM.ClearCallHistory();
            Console.WriteLine("Successfully deleted the call history!");
            testCallHistoryOfGSM.PrintCallHistory();
        }
    }
}
