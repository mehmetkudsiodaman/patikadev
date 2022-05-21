using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int zero = 0;
        int negative = 0;
        int positive = 0;
        
        double zeroRatio = 0;
        double negativeRatio = 0;
        double positiveRatio = 0;
        
        for(int i = 0; i < arr.Count; i++)
        {
            if(arr[i] == 0) zero += 1;
            if(arr[i] < 0) negative += 1;
            if(arr[i] > 0) positive += 1;
            
            Console.WriteLine(arr[i]);
            Console.WriteLine(zero);
            Console.WriteLine(positive);
            Console.WriteLine(negative);
            Console.WriteLine("---");
        }
        
        positiveRatio = (double)positive / (double)arr.Count();
        negativeRatio = (double)negative / (double)arr.Count();
        zeroRatio = (double)zero / (double)arr.Count();
        
        Console.WriteLine(String.Format("{0:0.000000}",positiveRatio));
        Console.WriteLine(String.Format("{0:0.000000}",negativeRatio));
        Console.WriteLine(String.Format("{0:0.000000}",zeroRatio));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}