////Problem 17. Longest string
////Write a program to return the string with maximum length from an array of strings.
////Use LINQ.

namespace LongestString
{
    using System;
    using System.Linq;
    using System.Text;

    public class LongestString
    {
        public static void Main(string[] args)
        {
            string[] stringArrary = new string[] { "aaa", "abbbbbbbbb", "acccc" };
            var longesStringFromArray =
                from items in stringArrary
                orderby items.Length descending
                select items;
            Console.WriteLine("The longest string form the array - {0} is {1}.", string.Join(", ", stringArrary), longesStringFromArray.FirstOrDefault());
        }
    }
}
