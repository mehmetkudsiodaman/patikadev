using System;
 
class SelectionSort
{
    static void sort(int []arr)
    {
        int n = arr.Length;
 
        for (int i = 0; i < n - 1; i++)
        {
            int minNum = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[minNum])
                    minNum = j;
 
            int temp = arr[minNum];
            arr[minNum] = arr[i];
            arr[i] = temp;
        }
    }
 
    static void printArray(int []arr)
    {
        int n = arr.Length;
        for (int i=0; i<n; ++i)
            Console.Write(arr[i]+" ");
        Console.WriteLine();
    }
 
    public static void Main()
    {
        int []arr = {12, 65, 89, 54, 3, 41, 6};
		
		Console.WriteLine("Array");
		printArray(arr);
		
        sort(arr);
		
        Console.WriteLine("Sorted array");
        printArray(arr);
    }
 
}