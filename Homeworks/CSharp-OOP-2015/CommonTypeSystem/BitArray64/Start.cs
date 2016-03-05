namespace BitArray64
{
    using System;

    public class Start
    {
        public static void Main()
        {
            var firstTest = new BitArray64(ulong.MaxValue - 1);
            var secondTest = new BitArray64(ulong.MaxValue);
            var thirdTest = new BitArray64(ulong.MaxValue);
            Console.WriteLine(firstTest[0]);
            foreach (var item in firstTest)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine(firstTest == secondTest);
            Console.WriteLine(firstTest != secondTest);
            Console.WriteLine(secondTest == thirdTest);
        }
    }
}