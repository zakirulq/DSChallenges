using System;

namespace BinarySearch
{
    public class TopKFrequentTest
    {
        public static void TestTopKFrequent()
        {
            Console.WriteLine("--- Testing Top K Frequent Elements ---");
            TopKFrequentSolution sol = new TopKFrequentSolution();

            // Test 1: Basic case
            Console.WriteLine("1. Testing Basic Case:");
            int[] nums1 = { 1, 1, 1, 2, 2, 3 };
            int k1 = 2;
            Console.Write("Input array: ");
            sol.PrintArray(nums1);
            Console.WriteLine($"k = {k1}");
            
            int[] result1 = sol.TopKFrequent(nums1, k1);
            Console.Write("Top K frequent elements (Heap approach): ");
            sol.PrintArray(result1);
            // Expected: [1, 2]

            int[] result1b = sol.TopKFrequentBucketSort(nums1, k1);
            Console.Write("Top K frequent elements (Bucket Sort): ");
            sol.PrintArray(result1b);
            // Expected: [1, 2]

            // Test 2: Single element
            Console.WriteLine("\n2. Testing Single Element:");
            int[] nums2 = { 1 };
            int k2 = 1;
            Console.Write("Input array: ");
            sol.PrintArray(nums2);
            Console.WriteLine($"k = {k2}");
            
            int[] result2 = sol.TopKFrequent(nums2, k2);
            Console.Write("Top K frequent elements: ");
            sol.PrintArray(result2);
            // Expected: [1]

            // Test 3: All elements have same frequency
            Console.WriteLine("\n3. Testing Same Frequency:");
            int[] nums3 = { 1, 2, 3, 4, 5 };
            int k3 = 3;
            Console.Write("Input array: ");
            sol.PrintArray(nums3);
            Console.WriteLine($"k = {k3}");
            
            int[] result3 = sol.TopKFrequent(nums3, k3);
            Console.Write("Top K frequent elements: ");
            sol.PrintArray(result3);
            // Expected: [1, 2, 3] (any 3 elements in any order)

            // Test 4: Complex case with different frequencies
            Console.WriteLine("\n4. Testing Complex Case:");
            int[] nums4 = { 1, 1, 1, 2, 2, 2, 3, 3, 4, 5, 6, 7, 8, 9 };
            int k4 = 3;
            Console.Write("Input array: ");
            sol.PrintArray(nums4);
            Console.WriteLine($"k = {k4}");
            
            int[] result4 = sol.TopKFrequent(nums4, k4);
            Console.Write("Top K frequent elements: ");
            sol.PrintArray(result4);
            // Expected: [1, 2, 3] (all have frequency 3)

            // Test 5: Quick Select approach
            Console.WriteLine("\n5. Testing Quick Select Approach:");
            int[] nums5 = { 1, 1, 1, 2, 2, 3 };
            int k5 = 2;
            Console.Write("Input array: ");
            sol.PrintArray(nums5);
            Console.WriteLine($"k = {k5}");
            
            int[] result5 = sol.TopKFrequentQuickSelect(nums5, k5);
            Console.Write("Top K frequent elements (Quick Select): ");
            sol.PrintArray(result5);
            // Expected: [1, 2]

            // Test 6: LINQ approach
            Console.WriteLine("\n6. Testing LINQ Approach:");
            int[] nums6 = { 1, 1, 1, 2, 2, 3 };
            int k6 = 2;
            Console.Write("Input array: ");
            sol.PrintArray(nums6);
            Console.WriteLine($"k = {k6}");
            
            int[] result6 = sol.TopKFrequentLinq(nums6, k6);
            Console.Write("Top K frequent elements (LINQ): ");
            sol.PrintArray(result6);
            // Expected: [1, 2]
            Console.WriteLine();
        }
    }
} 