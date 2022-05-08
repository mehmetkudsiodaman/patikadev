//String Challenge

/*Have the function StringChallenge(str) take the str parameter being passed and return a compressed
version of the string using the Run-length encoding algorithm. This algorithm works by taking the
occurrence of each repeating character and outputting that number along with a single character of
the repeating sequence. For example: "wwwggopp" would return 3w2g1o2p. The string will not contain
any numbers, punctuation, or symbols.
*/

/*
1. For input "aabbcc" the output was incorrect. The correct output is 2a2b2c

2. For input "aaaaaaabbbeiiiiggggg" the output was incorrect. The correct output is 7a3b1e4i5g

3. For input "coolthree" the output was incorrect. The correct output is 1c2o1l1t1h1r2e

4. For input "zzzaaappeefffffffmfgg" the output was incorrect. The correct output is 3z3a2p2e7f1m1f2g

5. For input "abqq" the output was incorrect. The correct output is 1a1b2q

6. For input "s" the output was incorrect. The correct output is 1s
*/

using System;

class MainClass1
{

    public static string StringChallenge(string str)
    {
        string newStr = null;
        int i;
        int c = 1;

        for (i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                c++;
            }
            else
            {
                newStr += c;
                newStr += str[i];
                c = 1;
            }
        }
        if (str[str.Length - 1] != str[str.Length - 2])
        {
            newStr += "1";
            newStr += str[str.Length - 1];
        }
        return newStr;
    }


    static void Main()
    {
        // keep this function call here
        Console.WriteLine(StringChallenge(Console.ReadLine()));
    }

}

//For this challenge you will determine which word has the greatest number of repeated letters.

/*Have the function SearchingChallenge(str) take the str parameter being passed and return the
 first word with the greatest number of repeated letters. For example: "Today, is the greatest
 day ever!" should return greatest because it has 2 e's (and 2 t's) and it comes before ever
 which also has 2 e's. If there are no words with repeating letters return -1. Words will be
 separated by spaces.
*/


class MainClass2
{

    public static string SearchingChallenge(string str)
    {

        // code goes here
        string[] words = str.Split(" ");
        int arraySize = words.Length;
        int[] counters = new int[arraySize - 1];

        foreach (string s in words)
        {
            int i = 0;
            for (int j = 0; j < s.Length - 1; j++)
            {
                if (s[j] == s[j + 1])
                {
                    counters[i]++;
                }
            }
            Console.WriteLine(counters[i]);
            i++;
        }

        if (counters.Max() == 0)
        {
            return (-1).ToString();
        }
        else
        {
            return words[Array.IndexOf(counters, counters.Max())].ToString();
        }
    }


    static void Main()
    {
        // keep this function call here
        Console.WriteLine(SearchingChallenge(Console.ReadLine()));
    }

}



//For this challenge you will traverse a string searching for all the numbers and then
//you will add them up.

/*Have the function SearchingChallenge(str) take the str parameter, search for all the
 numbers in the string, add them together, then return that final number divided by the
 total amount of letters in the string. For example: if str is "Hello6 9World 2,
 Nic8e D7ay!" the output should be 2. First if you add up all the numbers,
 6 + 9 + 2 + 8 + 7 you get 32. Then there are 17 letters in the string. 32 / 17 = 1.882,
 and the final answer should be rounded to the nearest whole number, so the answer is 2.
 Only single digit numbers separated by spaces will be used throughout the whole string
 (So this won't ever be the case: hello44444 world). Each string will also
 have at least one letter.
*/


//TODO: for "3ko6" --> output is wrong

class MainClass3
{

    public static string SearchingChallenge(string str)
    {
        decimal letterCount = AlphaCounter(str);
        decimal numsTotal = NumsAdder(str);
        return (Math.Round(numsTotal / letterCount)).ToString();
    }

    public static int AlphaCounter(string str)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnoprstuvwxyz".ToCharArray();
        char[] array = str.ToCharArray();
        int alphaCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            var checkAlpha = Array.Exists(alpha, x => x == array[i]);

            if (checkAlpha == true)
            {
                alphaCount++;
            }
        }

        return alphaCount;
    }

    public static int NumsAdder(string str)
    {
        char[] num = "1234567890".ToCharArray();
        char[] array = str.ToCharArray();
        int total = 0;

        for (int i = 0; i < array.Length; i++)
        {
            var checkNum = Array.Exists(num, x => x == array[i]);

            if (checkNum == true)
            {
                total += int.Parse(array[i].ToString());
            }
        }

        return total;
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(SearchingChallenge(Console.ReadLine()));
    }
}