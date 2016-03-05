namespace MobilePhone
{
    using System;
    class GSMTest
    {
        public static void StartGSMTest()
        {
            GSM[] testArray = new GSM[4];
            testArray[0] = new GSM("6230", "Nokia", 2.34m, "Gosho Peshov", new[] { "Bluetooth", "WI-FI" }, new Battery("Battery for Nokia 6230", 48d, 8d, BatteryType.Li_Ion), new Display(5d, 12000000));
            testArray[1] = new GSM("Edge", "Samsung", 5.34m, "Ivan Ivanov", new[] { "Camera", "WI-FI" }, new Battery("Battery", 48d, 8d, BatteryType.Li_Ion_Polymer), new Display(5.6d, 16000000));
            testArray[2] = new GSM("LG", "Flex", "John", new[] { "Bluetooth", "WI-FI", "Camera" }, new Battery("Some model", BatteryType.Li_Ion_Polymer), new Display(4.7d));
            testArray[3] = new GSM("Iphone", "Apple", "Tim Cook", new[] { "Bluetooth", "WI-FI", "Camera", "GPS", "Force Field" }, new Battery("iPhone battery", BatteryType.Li_Ion_Polymer), new Display(5.2d, 27000000));
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i]);
                Console.WriteLine(new string('-', 80));
            }
        }
    }
}
