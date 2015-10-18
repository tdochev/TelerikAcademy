//Problem 2. Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:
//weight 	weight on the Moon
//86 	14.62
//74.6 	12.682
//53.7 	9.129

using System;

class GravitationOnTheMoon
{
    const decimal gravityOfTheMoon = 17 / 100m;
    static void Main()
    {
        decimal[] weightonEarth = new decimal[3] { 86m, 74.6m, 53.7m };
        Console.WriteLine("{0,-6}  -  {1,-15}","Weight","Weight on the Moon");
        for (int i = 0; i < weightonEarth.Length; i++)
        {
            Console.WriteLine("{0,-6}  -  {1,-15}",weightonEarth[i], weightonEarth[i] * gravityOfTheMoon);
        }
    }
}

