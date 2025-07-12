using System;

public class BinarySearchTest
{
    public static void TestBinarySearch()
    {
        Console.WriteLine("--- Testing Binary Search and Variants ---");
        BinarySearchSolution sol = new BinarySearchSolution();

        // Test 1: Standard Binary Search
        Console.WriteLine("1. Testing Standard Binary Search:");
        int[] nums1 = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int target1 = 7;
        Console.Write("Array: ");
        sol.PrintArray(nums1);
        Console.WriteLine($"Target: {target1}");
        
        int result1 = sol.BinarySearch(nums1, target1);
        Console.WriteLine($"Found at index: {result1}");
        // Expected: 3

        int result1b = sol.BinarySearch(nums1, 10);
        Console.WriteLine($"Searching for 10: {result1b}");
        // Expected: -1 (not found)

        // Test 2: Find First Occurrence
        Console.WriteLine("\n2. Testing Find First Occurrence:");
        int[] nums2 = { 1, 2, 2, 2, 3, 4, 5 };
        int target2 = 2;
        Console.Write("Array: ");
        sol.PrintArray(nums2);
        Console.WriteLine($"Target: {target2}");
        
        int result2 = sol.FindFirstOccurrence(nums2, target2);
        Console.WriteLine($"First occurrence at index: {result2}");
        // Expected: 1

        // Test 3: Find Last Occurrence
        Console.WriteLine("\n3. Testing Find Last Occurrence:");
        Console.Write("Array: ");
        sol.PrintArray(nums2);
        Console.WriteLine($"Target: {target2}");
        
        int result3 = sol.FindLastOccurrence(nums2, target2);
        Console.WriteLine($"Last occurrence at index: {result3}");
        // Expected: 3

        // Test 4: Find Ceiling
        Console.WriteLine("\n4. Testing Find Ceiling:");
        int[] nums4 = { 1, 3, 5, 7, 9, 11 };
        int target4 = 6;
        Console.Write("Array: ");
        sol.PrintArray(nums4);
        Console.WriteLine($"Target: {target4}");
        
        int result4 = sol.FindCeiling(nums4, target4);
        Console.WriteLine($"Ceiling index: {result4}, value: {(result4 != -1 ? nums4[result4].ToString() : "not found")}");
        // Expected: 3 (value 7)

        // Test 5: Find Floor
        Console.WriteLine("\n5. Testing Find Floor:");
        Console.Write("Array: ");
        sol.PrintArray(nums4);
        Console.WriteLine($"Target: {target4}");
        
        int result5 = sol.FindFloor(nums4, target4);
        Console.WriteLine($"Floor index: {result5}, value: {(result5 != -1 ? nums4[result5].ToString() : "not found")}");
        // Expected: 2 (value 5)

        // Test 6: Search in Rotated Sorted Array
        Console.WriteLine("\n6. Testing Search in Rotated Sorted Array:");
        int[] nums6 = { 4, 5, 6, 7, 0, 1, 2 };
        int target6 = 0;
        Console.Write("Array: ");
        sol.PrintArray(nums6);
        Console.WriteLine($"Target: {target6}");
        
        int result6 = sol.SearchInRotatedArray(nums6, target6);
        Console.WriteLine($"Found at index: {result6}");
        // Expected: 4

        int result6b = sol.SearchInRotatedArray(nums6, 3);
        Console.WriteLine($"Searching for 3: {result6b}");
        // Expected: -1 (not found)

        // Test 7: Find Minimum in Rotated Array
        Console.WriteLine("\n7. Testing Find Minimum in Rotated Array:");
        int[] nums7 = { 3, 4, 5, 1, 2 };
        Console.Write("Array: ");
        sol.PrintArray(nums7);
        
        int result7 = sol.FindMinInRotatedArray(nums7);
        Console.WriteLine($"Minimum value: {result7}");
        // Expected: 1

        // Test 8: Search in 2D Matrix
        Console.WriteLine("\n8. Testing Search in 2D Matrix:");
        int[,] matrix = {
            { 1,  3,  5,  7},
            {10, 11, 16, 20},
            {23, 30, 34, 60}
        };
        Console.WriteLine("Matrix:");
        sol.PrintMatrix(matrix);
        
        int target8 = 16;
        Console.WriteLine($"Target: {target8}");
        bool result8 = sol.SearchMatrix(matrix, target8);
        Console.WriteLine($"Found: {result8}");
        // Expected: true

        bool result8b = sol.SearchMatrix(matrix, 13);
        Console.WriteLine($"Searching for 13: {result8b}");
        // Expected: false

        // Test 9: Find Peak Element
        Console.WriteLine("\n9. Testing Find Peak Element:");
        int[] nums9 = { 1, 2, 3, 1 };
        Console.Write("Array: ");
        sol.PrintArray(nums9);
        
        int result9 = sol.FindPeakElement(nums9);
        Console.WriteLine($"Peak element index: {result9}, value: {nums9[result9]}");
        // Expected: 2 (value 3)

        // Test 10: Square Root
        Console.WriteLine("\n10. Testing Square Root:");
        int x = 8;
        Console.WriteLine($"x = {x}");
        
        int result10 = sol.MySqrt(x);
        Console.WriteLine($"Square root: {result10}");
        // Expected: 2

        int x2 = 16;
        Console.WriteLine($"x = {x2}");
        
        int result10b = sol.MySqrt(x2);
        Console.WriteLine($"Square root: {result10b}");
        // Expected: 4
        Console.WriteLine();
    }
} 