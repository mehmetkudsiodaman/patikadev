//Letter Changes

//Have the function LetterChanges(str) take the str parameter
//being passed and modify it using the following algorithm.
//Replace every letter in the string with the letter following
//it in the alphabet (ie. c becomes d, z becomes a). Then capitalize
//every vowel in this new string (a, e, i, o, u) and
//finally return this modified string.

using System;

class MainClass1
{

    public static string StringChallenge(string str)
    {
        // code goes here
        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] array = str.ToCharArray();
        char letter;
        for (int i = 0; i < array.Length; i++)
        {
            var check = Array.Exists(alpha, x => x == array[i]);

            if (check == true)
            {
                letter = array[i];
                letter = (char)(array[i] + 1);

                if (letter == 'a')
                    array[i] = 'A';
                else if (letter == 'e')
                    array[i] = 'E';
                else if (letter == 'i')
                    array[i] = 'I';
                else if (letter == 'u')
                    array[i] = 'U';
                else if (letter == 'o')
                    array[i] = 'O';
                else array[i] = (char)(array[i] + 1);
            }
            else
            {
                letter = array[i];
            }

        }

        str = new string(array);
        return str;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(StringChallenge(Console.ReadLine()));
    }

}

//Division

//Have the function Division(num1,num2) take both parameters being passed
//and return the Greatest Common Factor. That is, return
//the greatest number that evenly goes into both numbers
//with no remainder. For example: 12 and 16 both are divisible
//by 1, 2, and 4 so the output should be 4. The range for both
//parameters will be from 1 to 10^3.


class MainClass2
{

    public static int MathChallenge(int num1, int num2)
    {
        // code goes here
        if ((num1 != 0 && num2 != 0))
        {
            if (num1 > num2)
                if (num1 % num2 == 0)
                    return num2;
                else
                    return num1 % num2;
            else
              if (num2 % num1 == 0)
                return num1;
            else
                return num2 % num1;
        }
        else
        {
            return -1;
        }
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(MathChallenge(Console.ReadLine()));
    }
}