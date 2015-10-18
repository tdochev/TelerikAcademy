//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.
//Examples:
//n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
//2011 	4 	            1102 	    1201 	                2101
//3333 	12 	            3333 	    3333 	                3333
//9876 	30 	            6789 	    6987 	                9786

using System;
using System.Text;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter a four digit number not starting with zero:");
        int numberN = int.Parse(Console.ReadLine());
        int input = numberN;
        int forthDigit = numberN % 10;
        numberN /= 10;
        int thirdDigit = numberN % 10;
        numberN /= 10;
        int secondDigit = numberN % 10;
        numberN /= 10;
        int firstDigit = numberN % 10;
        numberN /= 10;
        int sumOfDigits = firstDigit + secondDigit + thirdDigit + forthDigit;
        int reversed = (forthDigit * 1000) + (thirdDigit * 100) + (secondDigit * 10) + firstDigit;
        int lastDigitInFront = (forthDigit * 1000) + (secondDigit * 100) + (thirdDigit * 10) + firstDigit;
        int secondAndThirdExchanged = (firstDigit * 1000) + (thirdDigit * 100) + (secondDigit * 10) + forthDigit;

        Console.WriteLine("Input: {0}\nSum of digits: {1}\nReversed: {2}\nLast digit in front: {3}\nSecond and third digits exchanged: {4}", input, sumOfDigits, reversed, lastDigitInFront, secondAndThirdExchanged);
    }
}

