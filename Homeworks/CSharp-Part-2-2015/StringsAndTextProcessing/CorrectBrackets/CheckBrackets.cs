//Problem 3. Correct brackets
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckBrackets
{
    static bool CheckBracketsInExpression(string input)
    {
        Stack<char> stack = new Stack<char>();
        bool bracketsAreCorrect = true;
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (currentChar == '(')
            {
                stack.Push(currentChar);
            }
            else if (currentChar == ')')
            {
                if (!stack.Contains('('))
                {
                    bracketsAreCorrect = false;
                    break;
                }
                while (stack.Peek() != '(')
                {
                    stack.Pop();
                }
                stack.Pop();
            }
        }
        while (stack.Count > 0)
        {
            if (stack.Peek() == '(' || stack.Peek() == ')')
            {
                bracketsAreCorrect = false;
                break;
            }
        }
        return bracketsAreCorrect;
    }
    static void Main()
    {
        Console.WriteLine("Please enter an expression to check if the brackets are put correctly: ");
        string expression = Console.ReadLine();
        Console.WriteLine("the brackets are put {0}", CheckBracketsInExpression(expression) ? "correctly" : "incorrectly");
    }
}
