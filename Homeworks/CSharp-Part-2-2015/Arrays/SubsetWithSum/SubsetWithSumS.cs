//Problem 16.* Subset with sum S
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:
//input array 	S 	result
//2, 1, 2, 4, 3, 5, 2, 6 	14 	yes

using System;

class SubsetWithSumS
{
    static void Main()
    {
        int Sum = 14;
        int[] inputArray = { 20, 10, 20, 4, 30, 50, 20, 60 };
        Console.WriteLine(subSetDP(inputArray, Sum));
    }
    public static bool subSetDP(int[] A, int sum) 
        {
		bool[,] solution = new bool[A.Length + 1,sum + 1];		
		// if sum is not zero and subset is 0, we can't make it 
		for(int i=1;i<=sum;i++)
        {
			solution[0,i]=false;
		}
		// if sum is 0 the we can make the empty subset to make sum 0
				for(int i=0;i<=A.Length;i++)
                {
					solution[i,0]=true;
				}
		//
		for(int i=1;i<=A.Length;i++){
			for(int j=1;j<=sum;j++){				
				//first copy the data from the top
				solution[i,j] = solution[i-1,j];
				
				//If solution[i][j]==false check if can be made
				if(solution[i,j]==false && j>=A[i-1])
					solution[i,j] = solution[i,j] || solution[i-1,j-A[i-1]];				
			}
		}		
		return solution[A.Length,sum];
    }
}

