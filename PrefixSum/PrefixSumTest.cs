using System;

namespace PrefixSum
{
    public class PrefixSumTest
    {
        public static void TestPrefixSum()
        {
            Console.WriteLine("--- Testing Prefix Sum Problems ---");
            PrefixSumSolution sol = new PrefixSumSolution();

            // Test 1: Basic Prefix Sum
            Console.WriteLine("1. Testing Basic Prefix Sum:");
            int[] nums1 = { 1, 2, 3, 4, 5 };
            Console.Write("Original array: ");
            sol.PrintArray(nums1);
            
            int[] prefixSum1 = sol.CalculatePrefixSum(nums1);
            sol.PrintPrefixSum(prefixSum1);
            // Expected: [0, 1, 3, 6, 10, 15]

            // Test 2: Range Sum Query
            Console.WriteLine("\n2. Testing Range Sum Query:");
            Console.Write("Array: ");
            sol.PrintArray(nums1);
            Console.WriteLine("Prefix Sum:");
            sol.PrintPrefixSum(prefixSum1);
            
            int rangeSum1 = sol.RangeSumQuery(prefixSum1, 1, 3);
            Console.WriteLine($"Sum from index 1 to 3: {rangeSum1}");
            // Expected: 9 (2 + 3 + 4)

            int rangeSum2 = sol.RangeSumQuery(prefixSum1, 0, 4);
            Console.WriteLine($"Sum from index 0 to 4: {rangeSum2}");
            // Expected: 15 (1 + 2 + 3 + 4 + 5)

            // Test 3: Subarray Sum Equals K
            Console.WriteLine("\n3. Testing Subarray Sum Equals K:");
            int[] nums3 = { 1, 1, 1 };
            int k3 = 2;
            Console.Write("Array: ");
            sol.PrintArray(nums3);
            Console.WriteLine($"Target sum: {k3}");
            
            int count3 = sol.SubarraySumEqualsK(nums3, k3);
            Console.WriteLine($"Number of subarrays with sum {k3}: {count3}");
            // Expected: 2

            // Test 4: Maximum Subarray Sum
            Console.WriteLine("\n4. Testing Maximum Subarray Sum:");
            int[] nums4 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.Write("Array: ");
            sol.PrintArray(nums4);
            
            int maxSum4 = sol.MaxSubArraySum(nums4);
            Console.WriteLine($"Maximum subarray sum: {maxSum4}");
            // Expected: 6

            // Test 5: Maximum Subarray Sum with Size K
            Console.WriteLine("\n5. Testing Maximum Subarray Sum with Size K:");
            int[] nums5 = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
            int k5 = 4;
            Console.Write("Array: ");
            sol.PrintArray(nums5);
            Console.WriteLine($"Window size: {k5}");
            
            int maxSum5 = sol.MaxSubArraySumSizeK(nums5, k5);
            Console.WriteLine($"Maximum sum of subarray with size {k5}: {maxSum5}");
            // Expected: 24

            // Test 6: Minimum Subarray Sum with Size K
            Console.WriteLine("\n6. Testing Minimum Subarray Sum with Size K:");
            Console.Write("Array: ");
            sol.PrintArray(nums5);
            Console.WriteLine($"Window size: {k5}");
            
            int minSum6 = sol.MinSubArraySumSizeK(nums5, k5);
            Console.WriteLine($"Minimum sum of subarray with size {k5}: {minSum6}");
            // Expected: 6

            // Test 7: Maximum Subarray Sum with At Most K Elements
            Console.WriteLine("\n7. Testing Maximum Subarray Sum with At Most K Elements:");
            int[] nums7 = { 1, 2, 3, 4, 5 };
            int k7 = 3;
            Console.Write("Array: ");
            sol.PrintArray(nums7);
            Console.WriteLine($"Maximum elements: {k7}");
            
            int maxSum7 = sol.MaxSubArraySumAtMostK(nums7, k7);
            Console.WriteLine($"Maximum sum with at most {k7} elements: {maxSum7}");
            // Expected: 9

            // Test 8: Count Subarrays with Sum in Range
            Console.WriteLine("\n8. Testing Count Subarrays with Sum in Range:");
            int[] nums8 = { 1, 2, 3, 4, 5 };
            int lower8 = 3, upper8 = 8;
            Console.Write("Array: ");
            sol.PrintArray(nums8);
            Console.WriteLine($"Range: [{lower8}, {upper8}]");
            
            int count8 = sol.CountSubarraysInRange(nums8, lower8, upper8);
            Console.WriteLine($"Number of subarrays with sum in range: {count8}");
            // Expected: 6

            // Test 9: Maximum Sum of Two Non-Overlapping Subarrays
            Console.WriteLine("\n9. Testing Maximum Sum of Two Non-Overlapping Subarrays:");
            int[] nums9 = { 0, 6, 5, 2, 2, 5, 1, 9, 4 };
            int firstLen9 = 1, secondLen9 = 2;
            Console.Write("Array: ");
            sol.PrintArray(nums9);
            Console.WriteLine($"First length: {firstLen9}, Second length: {secondLen9}");
            
            int maxSum9 = sol.MaxSumTwoNoOverlap(nums9, firstLen9, secondLen9);
            Console.WriteLine($"Maximum sum of two non-overlapping subarrays: {maxSum9}");
            // Expected: 20

            // Test 10: Maximum Sum of Three Non-Overlapping Subarrays
            Console.WriteLine("\n10. Testing Maximum Sum of Three Non-Overlapping Subarrays:");
            int[] nums10 = { 1, 2, 1, 2, 6, 7, 5, 1 };
            int k10 = 2;
            Console.Write("Array: ");
            sol.PrintArray(nums10);
            Console.WriteLine($"Subarray length: {k10}");
            
            int[] result10 = sol.MaxSumThreeNoOverlap(nums10, k10);
            Console.Write("Indices of three non-overlapping subarrays: ");
            sol.PrintArray(result10);
            // Expected: [0, 3, 5] or similar valid combination
            Console.WriteLine();
        }
    }
} 