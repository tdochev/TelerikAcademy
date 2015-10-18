//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:
//n 	Third digit 7?
//5 	false
//701 	true
//9703 	true
//877 	false
//777877 	false
//9999799 	true

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int[] nArray = new int[6] { 5, 701, 9703, 877, 777877, 9999799 };
        Console.WriteLine("{0,-7}  -  {1,-15}", "n", "Third digit 7?");
        for (int i = 0; i < nArray.Length; i++)
        {
            bool ThirdDigitIs7 = nArray[i] / 100 % 10 == 7;
            Console.WriteLine("{0,-7}  -  {1,-15}",nArray[i] ,ThirdDigitIs7);
        }
    }
}
