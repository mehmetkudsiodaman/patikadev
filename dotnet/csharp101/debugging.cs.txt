using System;

namespace csharp101
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Entered number is {num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message.ToString()}");
                //throw;
            }
            finally
            {
                Console.WriteLine("Process is completed!");
            }
        }
    }
}