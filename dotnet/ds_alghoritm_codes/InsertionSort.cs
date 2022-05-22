using System;

class InsertionSort
{

    void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");

        Console.Write("\n");
    }

    public static void Main()
    {
        int[] arr = { 12, 65, 89, 11, 13, 5, 6 };
		
		Console.WriteLine("Array");
        PrintArray(arr);
		
        InsertionSort insertionSort = new InsertionSort();
        insertionSort.Sort(arr);
		
		Console.WriteLine("Sorted array");
        PrintArray(arr);
    }
}