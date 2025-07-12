using System;
using System.Linq;

namespace MergeOperations
{
    public class MergeIntervalTest
    {
        public static void TestMergeIntervals()
        {
            Console.WriteLine("--- Testing Merge Intervals ---");
            MergeIntervalSolution sol = new MergeIntervalSolution();

            int[][] intervals1 = new int[][]
            {
                new int[] {1, 3},
                new int[] {2, 6},
                new int[] {8, 10},
                new int[] {15, 18}
            };
            int[][] result1 = sol.Merge(intervals1);
            Console.WriteLine($"Merged intervals for [[1, 3], [2, 6], [8, 10], [15, 18]]: {string.Join(", ", result1.Select(i => $"[{i[0]}, {i[1]}]"))}");
            // Expected: [[1, 6], [8, 10], [15, 18]]

            int[][] intervals2 = new int[][]
            {
                new int[] {1, 4},
                new int[] {4, 5}
            };
            int[][] result2 = sol.Merge(intervals2);
            Console.WriteLine($"Merged intervals for [[1, 4], [4, 5]]: {string.Join(", ", result2.Select(i => $"[{i[0]}, {i[1]}]"))}"); 
            // Expected: [[1, 5]]
            Console.WriteLine();
        }
    }
} 