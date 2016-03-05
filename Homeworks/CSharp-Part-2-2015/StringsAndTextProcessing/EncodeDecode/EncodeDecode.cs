//Problem 7. Encode/decode
//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;

class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Please enter a text to encode:");
        string input = Console.ReadLine();
        Console.WriteLine("Please enter a encryption key (cipher):");
        string cipher = Console.ReadLine();
        string encodedInput = string.Empty;
        string decodedInput = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            encodedInput += (char)(input[i] ^ cipher[i % cipher.Length]);
        }
        Console.WriteLine("The encoded input is:" + encodedInput);
        for (int i = 0; i < input.Length; i++)
        {
            decodedInput += (char)(encodedInput[i] ^ cipher[i % cipher.Length]);
        }
        Console.WriteLine("The decoded input is:" + decodedInput);
    }
}

