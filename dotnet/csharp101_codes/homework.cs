using System;

class Solution
{
    public static void Main(string[] args)
    {
        string n = Console.ReadLine();
        string[] nums = Console.ReadLine().Split(' ');
        string evens = "";
        foreach (string i in nums)
        {
            int evenCheck = Convert.ToInt32(i);
            if (evenCheck % 2 == 0)
                evens += evenCheck + " ";
        }
        Console.WriteLine(evens);
        Console.ReadLine();
    }
}