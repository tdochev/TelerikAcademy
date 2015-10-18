//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
//Examples:
//n 	Divided by 7 and 5?
//3 	false
//0 	true
//5 	false
//7 	false
//35 	true
//140 	true

using System;

class DivideBy7And5
{
    static void Main()
    {
        int[] nArray = new int[6] { 3, 0, 5, 7, 35, 140 };
        Console.WriteLine("{0,-3}  -  {1,-15}", "n", "Divided by 7 and 5?");
        for (int i = 0; i < nArray.Length; i++)
        {
            bool dividedBy7And3 = (nArray[i] % 5 == 0 && nArray[i] % 7 == 0);
            Console.WriteLine("{0,-3}  -  {1,-15}", nArray[i], dividedBy7And3);
        }
    }
}

