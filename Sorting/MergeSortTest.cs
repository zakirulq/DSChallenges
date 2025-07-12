using System;

namespace Sorting
{
    public class MergeSortTest
    {
        public static void TestMergeSort()
        {
            Console.WriteLine("--- Testing Merge Sort (Divide and Conquer) ---");
            MergeSortSolution sol = new MergeSortSolution();

            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.Write("Original array: ");
            sol.PrintArray(arr1);
            sol.MergeSort(arr1);
            Console.Write("Sorted array: ");
            sol.PrintArray(arr1);
            // Expected: [11, 12, 22, 25, 34, 64, 90]

            int[] arr2 = { 5, 2, 4, 6, 1, 3 };
            Console.Write("Original array: ");
            sol.PrintArray(arr2);
            sol.MergeSort(arr2);
            Console.Write("Sorted array: ");
            sol.PrintArray(arr2);
            // Expected: [1, 2, 3, 4, 5, 6]

            int[] arr3 = { 1 };
            Console.Write("Original array: ");
            sol.PrintArray(arr3);
            sol.MergeSort(arr3);
            Console.Write("Sorted array: ");
            sol.PrintArray(arr3);
            // Expected: [1]

            int[] arr4 = { 3, 1, 4, 1, 5, 9, 2, 6 };
            Console.Write("Original array: ");
            sol.PrintArray(arr4);
            sol.MergeSort(arr4);
            Console.Write("Sorted array: ");
            sol.PrintArray(arr4);
            // Expected: [1, 1, 2, 3, 4, 5, 6, 9]
            Console.WriteLine();
        }
    }
} 