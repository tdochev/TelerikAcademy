//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:
//numbers 	number as words
//0 	    Zero
//9 	    Nine
//10 	    Ten
//12 	    Twelve
//19 	    Nineteen
//25 	    Twenty five
//98 	    Ninety eight
//98 	    Ninety eight
//273 	    Two hundred and seventy three
//400 	    Four hundred
//501 	    Five hundred and one
//617 	    Six hundred and seventeen
//711 	    Seven hundred and eleven
//999 	    Nine hundred and ninety nine

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int hundreds = (number / 100) % 10;
        int tens = (number / 10) % 10;
        int ones = number % 10;
        string result = "";
        if (hundreds == 0 && tens == 0 && ones == 0)
        {
            result = "zero";
        }
        if (hundreds != 0)
        {
            switch (hundreds)
            {
                case 1:
                    result += "one hundred";
                    break;
                case 2:
                    result += "two hundred";
                    break;
                case 3:
                    result += "three hundred";
                    break;
                case 4:
                    result += "four hundred";
                    break;
                case 5:
                    result += "five hundred";
                    break;
                case 6:
                    result += "six hundred";
                    break;
                case 7:
                    result += "seven hundred";
                    break;
                case 8:
                    result += "eight hundred";
                    break;
                case 9:
                    result += "nine hundred";
                    break;

            }
            if (tens != 0 || ones != 0)
            {
                result += " and";
            }
        }
        if (tens != 0)
        {
            if (hundreds != 0)
            {
                result += " ";
            }
            if (tens < 2)
            {
                tens = (tens * 10) + ones;
            }
            switch (tens)
            {
                case 2:
                    result += "twenty";
                    break;
                case 3:
                    result += "thirty";
                    break;
                case 4:
                    result += "forty";
                    break;
                case 5:
                    result += "fifty";
                    break;
                case 6:
                    result += "sixty";
                    break;
                case 7:
                    result += "sevety";
                    break;
                case 8:
                    result += "eighty";
                    break;
                case 9:
                    result += "ninety";
                    break;
                case 10:
                    result += "ten";
                    break;
                case 11:
                    result += "eleven";
                    break;
                case 12:
                    result += "twelve";
                    break;
                case 13:
                    result += "thirteen";
                    break;
                case 14:
                    result += "fourteen";
                    break;
                case 15:
                    result += "fifteen";
                    break;
                case 16:
                    result += "sixteen";
                    break;
                case 17:
                    result += "seventeen";
                    break;
                case 18:
                    result += "eighteen";
                    break;
                case 19:
                    result += "nineteen";
                    break;
            }
        }
        if (tens != 0 || hundreds != 0 )
        {
            result += " ";
        }
        if (ones != 0)
        {
            if (tens > 20 || tens < 10 || tens == 0)
            {
                switch (ones)
                {
                    case 1:
                        result += "one";
                        break;
                    case 2:
                        result += "two";
                        break;
                    case 3:
                        result += "three";
                        break;
                    case 4:
                        result += "four";
                        break;
                    case 5:
                        result += "five";
                        break;
                    case 6:
                        result += "six";
                        break;
                    case 7:
                        result += "seven";
                        break;
                    case 8:
                        result += "eight";
                        break;
                    case 9:
                        result += "nine";
                        break;
                }
            }
        }
        Console.WriteLine(char.ToUpper(result[0]) + result.Substring(1));
    }
}