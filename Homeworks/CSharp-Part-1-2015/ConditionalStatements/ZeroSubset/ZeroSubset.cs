//Problem 12.* Zero Subset
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:
//numbers 	    result
//3 -2 1 1 8 	-2 + 1 + 1 = 0
//3 1 -7 35 22 	no zero subset
//1 3 -4 -2 -1 	1 + -1 = 0
//	            1 + 3 + -4 = 0
//	            3 + -2 + -1 = 0
//1 1 1 -1 -1 	1 + -1 = 0
//	            1 + 1 + -1 + -1 = 0
//0 0 0 0 0 	0 + 0 + 0 + 0 + 0 = 0
//Hint: you may check for zero each of the 31 subsets with 31 if statements.

using System;
using System.Collections.Generic;
using System.Text;

class ZeroSubset
{
    public static List<int> resultList = new List<int>();
    public static int tempSum = 0;
    const int sumToFind = 0;
    public static int numberOfSubsetsFound = 0;
    static void Main()
    {
        Console.WriteLine("Please enter numbers: ");
        string[] numbers = (Console.ReadLine()).Split(new char [] {' '},StringSplitOptions.RemoveEmptyEntries);
        int[] numbersArray = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbersArray[i] = int.Parse(numbers[i]);
        }
        //if (numbersArray[0] + numbersArray[1] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[0], numbersArray[1]);
        //}
        //if (numbersArray[0] + numbersArray[2] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[0], numbersArray[2]);
        //}
        //if (numbersArray[0] + numbersArray[3] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[0], numbersArray[3]);
        //}
        //if (numbersArray[0] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[0], numbersArray[4]);
        //}
        //if (numbersArray[1] + numbersArray[2] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[1], numbersArray[2]);
        //}
        //if (numbersArray[1] + numbersArray[3] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[1], numbersArray[3]);
        //}
        //if (numbersArray[1] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[1], numbersArray[4]);
        //}
        //if (numbersArray[2] + numbersArray[3] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[2], numbersArray[3]);
        //}
        //if (numbersArray[2] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} = 0", numbersArray[2], numbersArray[4]);
        //}
        //if (numbersArray[0] + numbersArray[1] + numbersArray[2] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[0], numbersArray[1], numbersArray[2]); 
        //}
        //if (numbersArray[0] + numbersArray[2] + numbersArray[3] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[0], numbersArray[2], numbersArray[3]);
        //}
        //if (numbersArray[0] + numbersArray[2] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[0], numbersArray[2], numbersArray[4]);
        //}
        //if (numbersArray[0] + numbersArray[1] + numbersArray[3] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[0], numbersArray[1], numbersArray[3]);
        //}
        //if (numbersArray[0] + numbersArray[1] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[0], numbersArray[1], numbersArray[4]);
        //}
        //if (numbersArray[0] + numbersArray[2] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[0], numbersArray[2], numbersArray[4]);
        //}
        //if (numbersArray[1] + numbersArray[2] + numbersArray[3] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[1], numbersArray[2], numbersArray[3]);
        //}
        //if (numbersArray[1] + numbersArray[2] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[1], numbersArray[2], numbersArray[4]);
        //}
        //if (numbersArray[1] + numbersArray[3] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[1], numbersArray[3], numbersArray[4]);
        //}
        //if (numbersArray[2] + numbersArray[3] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} = 0", numbersArray[2], numbersArray[3], numbersArray[4]);
        //}
        //if (numbersArray[0] + numbersArray[1] + numbersArray[2] + numbersArray[3] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbersArray[0], numbersArray[1], numbersArray[2], numbersArray[3]);
        //}
        //if (numbersArray[1] + numbersArray[2] + numbersArray[3] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbersArray[1], numbersArray[2], numbersArray[3], numbersArray[4]);
        //}
        //if (numbersArray[0] + numbersArray[1] + numbersArray[2] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbersArray[0], numbersArray[1], numbersArray[2], numbersArray[4]);
        //}
        //if (numbersArray[0] + numbersArray[1] + numbersArray[3] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbersArray[0], numbersArray[1], numbersArray[3], numbersArray[4]);
        //}
        //if (numbersArray[0] + numbersArray[1] + numbersArray[2] + numbersArray[3] + numbersArray[4] == 0)
        //{
        //    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbersArray[0], numbersArray[1], numbersArray[2], numbersArray[3], numbersArray[4]);
        //}
        //else
        //{
        //    Console.WriteLine("no zero subset");
        //}
        if (numbersArray[0] == 0 && numbersArray[1] == 0 && numbersArray[2] == 0 && numbersArray[3] == 0 && numbersArray[4] == 0) 
        {
            Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
        }
        else
        {
            RecursiveCalc(numbersArray, sumToFind, numbersArray.Length);
            if (numberOfSubsetsFound == 1)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
    public static void RecursiveCalc(int[] numbersArray, int startIndex, int endIndex)
     {
          for (int currentIndex = startIndex; currentIndex < endIndex; currentIndex++)
          {
              resultList.Add(numbersArray[currentIndex]);
              tempSum += numbersArray[currentIndex];
              RecursiveCalc(numbersArray, currentIndex + 1, endIndex);
              tempSum -= numbersArray[currentIndex];
              resultList.Remove(numbersArray[currentIndex]);
          }
          if (tempSum == sumToFind)
          {
              for (int i = 0; i < resultList.Count; i++)
              {
                  if (i != resultList.Count - 1)
                  {
                      Console.Write("{0} + ", resultList[i]);
                  }
                  if (i == resultList.Count - 1)
                  {
                      Console.Write("{0} = 0", resultList[i]);
                  }
              }
              numberOfSubsetsFound += 1;
              Console.WriteLine();
          }
    }
}
