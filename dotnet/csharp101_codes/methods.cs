using System;

class Solution
{
    public static void Main(string[] args)
    {
        string number = null;

        while (number != "q")
        {

            number = Console.ReadLine();
            int outNumber;

            bool result = int.TryParse(number, out outNumber);

            if (result)
            {
                Console.WriteLine("Success!");
                Console.WriteLine(outNumber);
            }
            else
            {
                Console.WriteLine("Failed!");
            }

            Console.Write("Press any key!");
            Console.ReadLine();
        }
    }
}