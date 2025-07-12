using System;

namespace TwoPointers
{
    public class TwoSumTest
    {
        public static void TestTwoSum()
        {
            Console.WriteLine("--- Testing Two Sum ---");
            TwoSumSolution sol = new TwoSumSolution();

            int[] numbers1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = sol.FindPair(numbers1, target1);
            Console.WriteLine($"Indices found for [2, 7, 11, 15] with target 9: [{string.Join(", ", result1)}]");
            // Expected: [0, 1] (indices of 2 and 7)

            int[] numbers2 = { 1, 3, 4, 5, 7, 10, 11 };
            int target2 = 9;
            int[] result2 = sol.FindPair(numbers2, target2);
            Console.WriteLine($"Indices found for [1, 3, 4, 5, 7, 10, 11] with target 9: [{string.Join(", ", result2)}]");
            // Expected: [2, 4] (indices of 4 and 5)
            Console.WriteLine();
        }
    }
} 