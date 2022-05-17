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



class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        CheckNum(N);
    }
    
    public static void CheckNum(int num)
    {
        //Weird ==> true, Not Weird ==> false, 
        if(num % 2 == 1)
        {
            PrintSituation(true);
        }
        else if(num % 2 == 0)
        {
            if(num > 20)
                PrintSituation(false);
            else if(num <= 20 && num >= 6)
                PrintSituation(true);
            else if(num <= 5 && num >= 2)
                PrintSituation(false);
        }
    }
    
    public static void PrintSituation(bool isWeird)
    {
        if(isWeird)
        {
            Console.WriteLine("Weird");
        }
        else
        {
            Console.WriteLine("Not Weird");
        }
    }
}
