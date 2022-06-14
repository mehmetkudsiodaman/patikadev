using System;

class Result
{

    /*
     * Complete the 'factorial' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int factorial(int n)
    {
        if (n==0)
            return 0;
        else if (n==1)
            return 1;
        else
            return n * factorial(n-1);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        while (true)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int result = Result.factorial(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}