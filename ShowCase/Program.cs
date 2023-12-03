using System;
using ArticleExamples;

class Program
{
    static void Main()
    {
        int[] sortedArray = { 1, 2, 3, 4, 5 };

        // Constant Time - O(1)
        Console.WriteLine(TimeComplexity.ConstantTimeLookup(sortedArray, 3));

        // Linear Time - O(n)
        Console.WriteLine(TimeComplexity.LinearSearch(sortedArray, 3));

        int[] unsortedArray = { 5, 3, 1, 4, 2 };

        // Quadratic Time - O(n^2)
        int[] bubbleSortArray = TimeComplexity.BubbleSort(unsortedArray);
        foreach (int i in bubbleSortArray)
        {
            Console.Write(i);
        }
        Console.WriteLine();

        // Logarithmic Time - O(log n)
        Console.WriteLine(TimeComplexity.BinarySearch(bubbleSortArray, 3));

        // Combining Linear and Logarithmic Time - O(n log n)
        int[] mergeSortArray = TimeComplexity.MergeSort(unsortedArray);
        foreach (int i in mergeSortArray)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}