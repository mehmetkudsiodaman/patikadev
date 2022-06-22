using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] types_temp = Console.ReadLine().Split(' ');
        int[] types = Array.ConvertAll(types_temp, Int32.Parse);
        
        int[] birdCounts = new int[6];

        foreach (var type in types)
            birdCounts[type]++;

        int maxValue = birdCounts.Max();
        int maxType = birdCounts.ToList().IndexOf(maxValue);

        Console.WriteLine(maxType);

    }
}
