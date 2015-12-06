//Problem 7.* Arithmetical expressions
//Write a program that calculates the value of given arithmetical expression.
//The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities): (, )
//Examples:
//input 	output
//(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) 	~10.6
//pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) 	~21.22
//Hint: Use the classical Shunting-yard algorithm and Reverse Polish notation.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;


class Calculator
{

    public static List<char> specialChars = new List<char>() { '+', '-', '/', '*', '(', ')', ',' };
    public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };
    public static List<string> operators = new List<string>() { "+", "-", "*", "/" };

    private static List<string> ExtractTokens(string input)
    {
        List<string> result = new List<string>();
        var number = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
            {
                number.Append('-');
            }
            else if (char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
            {
                result.Add(number.ToString());
                number.Clear();
                i--;
            }
            else if (specialChars.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (i < input.Length - 1 && input.Substring(i, 2).ToLower() == "ln")
            {
                result.Add("ln");
                i++;
            }
            else if (i < input.Length - 2 && input.Substring(i, 3).ToLower() == "pow")
            {
                result.Add("pow");
                i += 2;
            }
            else if (i < input.Length - 3 && input.Substring(i, 4).ToLower() == "sqrt")
            {
                result.Add("sqrt");
                i += 3;
            }
            else
            {
                throw new ArgumentException("Invalid expression!");
            }
        }

        if (number.Length != 0)
        {
            result.Add(number.ToString());
        }

        return result;

    }

    public static int Precedence(string command)
    {
        if (command == "+" || command == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    private static Queue<string> ConvertToRPN(List<string> tokens)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();
        for (int i = 0; i < tokens.Count; i++)
        {
            //Read a token.
            var currentToken = tokens[i];
            double currentNumber;
            //If the token is a number, then add it to the output queue.
            if (double.TryParse(currentToken, out currentNumber))
            {
                queue.Enqueue(currentToken);
            }
            //If the token is a function token, then push it onto the stack.
            else if (functions.Contains(currentToken))
            {
                stack.Push(currentToken);
            }
            //If the token is a function argument separator (e.g., a comma):
            else if (currentToken == ",")
            {
                //If no left parentheses are encountered, either the separator was misplaced or parentheses were mismat
                if (!stack.Contains("("))
                {
                    throw new ArgumentException("Invalid expression!");
                }
                //Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue. 
                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            //If the token is an operator, o1, then:
            else if (operators.Contains(currentToken))
            {
                //while there is an operator token, o2, at the top of the operator stack, and either
                //o1 is left-associative and its precedence is less than or equal to that of o2, or
                //o1 is right associative, and has precedence less than that of o2,
                while (stack.Count != 0 && operators.Contains(stack.Peek()) && Precedence(currentToken) <= Precedence(stack.Peek()))
                {
                    //then pop o2 off the operator stack, onto the output queue;
                    queue.Enqueue(stack.Pop());
                }
                //push o1 onto the operator stack.
                stack.Push(currentToken);
            }
            //If the token is a left parenthesis (i.e. "("), then push it onto the stack.
            else if (currentToken == "(")
            {
                stack.Push(currentToken);
            }
            //If the token is a right parenthesis (i.e. ")"):
            else if (currentToken == ")")
            {
                //If the stack runs out without finding a left parenthesis, then there are mismatched parentheses.
                if (!stack.Contains("("))
                {
                    throw new ArgumentException("Mismatched parentheses!");
                }
                //Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue.
                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }
                //Pop the left parenthesis from the stack, but not onto the output queue.
                stack.Pop();
                //If the token at the top of the stack is a function token, pop it onto the output queue.
                if (stack.Count != 0 && functions.Contains(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
            }
        }
        //When there are no more tokens to read:
        //While there are still operator tokens in the stack:
        while (stack.Count > 0)
        {
            //If the operator token on the top of the stack is a parenthesis, then there are mismatched parentheses.
            if (stack.Peek() == "(" || stack.Peek() == ")")
            {
                throw new ArgumentException("Mismatched parentheses!");
            }
            //Pop the operator onto the output queue.
            queue.Enqueue(stack.Pop());
        }
        return queue;
    }

    private static double CalculateRPN(Queue<string> queue)
    {
        Stack<double> stack = new Stack<double>();
        double finalResult;
        //While there are input tokens left
        while (queue.Count != 0)
        {
            //Read the next token from input.
            string currentToken = queue.Dequeue();
            double number;
            //If the token is a value
            if (double.TryParse(currentToken, out number))
            {
                //Push it onto the stack.
                stack.Push(number);
            }
            //Otherwise, the token is an operator (operator here includes both operators and functions).
            else
            {
                if (currentToken == "+")
                {
                    //It is known a priori that the operator takes n arguments.
                    //If there are fewer than n values on the stack
                    if (stack.Count < 2)
                    {
                        //(Error) The user has not input sufficient values in the expression.
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    //Else, Pop the top n values from the stack.
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        //Evaluate the operator, with the values as arguments.
                        double result = firstNumber + secondNumber;
                        //Push the returned results, if any, back onto the stack.
                        stack.Push(result);
                    }
                }
                else if (currentToken == "-")
                {
                    //It is known a priori that the operator takes n arguments.
                    //If there are fewer than n values on the stack
                    if (stack.Count < 2)
                    {
                        //(Error) The user has not input sufficient values in the expression.
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    //Else, Pop the top n values from the stack.
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        //Evaluate the operator, with the values as arguments.
                        double result = secondNumber - firstNumber;
                        //Push the returned results, if any, back onto the stack.
                        stack.Push(result);
                    }
                }
                else if (currentToken == "*")
                {
                    //It is known a priori that the operator takes n arguments.
                    //If there are fewer than n values on the stack
                    if (stack.Count < 2)
                    {
                        //(Error) The user has not input sufficient values in the expression.
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    //Else, Pop the top n values from the stack.
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        //Evaluate the operator, with the values as arguments.
                        double result = secondNumber * firstNumber;
                        //Push the returned results, if any, back onto the stack.
                        stack.Push(result);
                    }
                }
                else if (currentToken == "/")
                {
                    //It is known a priori that the operator takes n arguments.
                    //If there are fewer than n values on the stack
                    if (stack.Count < 2)
                    {
                        //(Error) The user has not input sufficient values in the expression.
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    //Else, Pop the top n values from the stack.
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        //Evaluate the operator, with the values as arguments.
                        double result = secondNumber / firstNumber;
                        //Push the returned results, if any, back onto the stack.
                        stack.Push(result);
                    }
                }
                else if (currentToken == "pow")
                {
                    //It is known a priori that the operator takes n arguments.
                    //If there are fewer than n values on the stack
                    if (stack.Count < 2)
                    {
                        //(Error) The user has not input sufficient values in the expression.
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    //Else, Pop the top n values from the stack.
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        //Evaluate the operator, with the values as arguments.
                        double result = Math.Pow(secondNumber, firstNumber);
                        //Push the returned results, if any, back onto the stack.
                        stack.Push(result);
                    }
                }
                else if (currentToken == "sqrt")
                {
                    //It is known a priori that the operator takes n arguments.
                    //If there are fewer than n values on the stack
                    if (stack.Count < 1)
                    {
                        //(Error) The user has not input sufficient values in the expression.
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    //Else, Pop the top n values from the stack.
                    else
                    {
                        double currentNumber = stack.Pop();
                        //Evaluate the operator, with the values as arguments.
                        double result = Math.Sqrt(currentNumber);
                        //Push the returned results, if any, back onto the stack.
                        stack.Push(result);
                    }
                }
                else if (currentToken == "ln")
                {
                    //It is known a priori that the operator takes n arguments.
                    //If there are fewer than n values on the stack
                    if (stack.Count < 1)
                    {
                        //(Error) The user has not input sufficient values in the expression.
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    //Else, Pop the top n values from the stack.
                    else
                    {
                        double currentNumber = stack.Pop();
                        //Evaluate the operator, with the values as arguments.
                        double result = Math.Log(currentNumber);
                        //Push the returned results, if any, back onto the stack.
                        stack.Push(result);
                    }
                }
            }
        }
        //If there is only one value in the stack
        if (stack.Count == 1)
        {
            //That value is the result of the calculation.
            finalResult = stack.Pop();
        }
        //Otherwise, there are more values in the stack
        else
        {
            //(Error) The user input has too many values.
            throw new ArgumentException("Invalid Expression");
        }
        return finalResult;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter an arithmetical expression: ");
        string input = Console.ReadLine().Trim().Replace(" ", string.Empty);
        List<string> tokens = ExtractTokens(input);
        Queue<string> reversedPolishNotation = ConvertToRPN(tokens); //Shunting-yard algorithm
        Console.WriteLine(CalculateRPN(reversedPolishNotation)); //Reverse Polish notation
    }
}

