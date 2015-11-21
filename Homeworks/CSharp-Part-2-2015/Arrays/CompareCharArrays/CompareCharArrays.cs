//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter)

using System;

    class CompareCharArrays
    {
        static void Main()
        {
            bool arraysMatch = true;
            char[] firstCharArray = "hello C#!".ToCharArray();
            char[] secondCharArray = "Hello C#!".ToCharArray();
            if (firstCharArray.Length != secondCharArray.Length)
            {
                Console.WriteLine("Your arrays have different lenght!");
                arraysMatch = false;
            }
            else
            {
                for (int i = 0; i < firstCharArray.Length; i++)
                {
                    if (firstCharArray[i] != secondCharArray[i])
	                {
                        arraysMatch = false;
                        break;
	                }
                }
            }
            if (arraysMatch == true)
            {
                Console.WriteLine("Your arrays are exactly the same.");
            }
            else
            {
                Console.WriteLine("Your arrays are not the same.");
            }
        }
    }

