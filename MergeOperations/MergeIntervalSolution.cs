
using System;
using System.Collections.Generic;

namespace MergeOperations
{
    public class MergeIntervalSolution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
            {
                return intervals;
            }

            // Sort intervals based on start time
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> merged = new List<int[]>();
            int[] currentInterval = intervals[0];
            merged.Add(currentInterval);

            for (int i = 1; i < intervals.Length; i++)
            {
                int currentStart = intervals[i][0];
                int currentEnd = intervals[i][1];
                int lastEnd = currentInterval[1];

                if (currentStart <= lastEnd)
                {
                    currentInterval[1] = Math.Max(lastEnd, currentEnd);
                }
                else
                {
                    currentInterval = intervals[i];
                    merged.Add(currentInterval);
                }
            }

            return merged.ToArray();
        }
    }
}
