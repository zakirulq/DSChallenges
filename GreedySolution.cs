using System;
using System.Collections.Generic;
using System.Linq;

public class GreedySolution
{
    // Interval class for interval problems
    public class Interval
    {
        public int start;
        public int end;
        
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
        
        public override string ToString()
        {
            return $"[{start}, {end}]";
        }
    }
    
    // Activity Selection Problem - Find maximum number of activities
    public int ActivitySelection(int[] start, int[] end)
    {
        if (start == null || end == null || start.Length == 0)
            return 0;
        
        // Create intervals and sort by end time
        var intervals = new List<Interval>();
        for (int i = 0; i < start.Length; i++)
        {
            intervals.Add(new Interval(start[i], end[i]));
        }
        
        intervals.Sort((a, b) => a.end.CompareTo(b.end));
        
        int count = 1; // First activity is always selected
        int lastEnd = intervals[0].end;
        
        for (int i = 1; i < intervals.Count; i++)
        {
            if (intervals[i].start >= lastEnd)
            {
                count++;
                lastEnd = intervals[i].end;
            }
        }
        
        return count;
    }
    
    // Minimum Number of Arrows to Burst Balloons
    public int FindMinArrowShots(int[][] points)
    {
        if (points == null || points.Length == 0)
            return 0;
        
        // Sort by end point
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        
        int arrows = 1;
        int end = points[0][1];
        
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] > end)
            {
                arrows++;
                end = points[i][1];
            }
        }
        
        return arrows;
    }
    
    // Non-overlapping Intervals
    public int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals == null || intervals.Length == 0)
            return 0;
        
        // Sort by end time
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        
        int count = 0;
        int end = intervals[0][1];
        
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < end)
            {
                count++; // Remove this interval
            }
            else
            {
                end = intervals[i][1];
            }
        }
        
        return count;
    }
    
    // Partition Labels
    public List<int> PartitionLabels(string s)
    {
        if (string.IsNullOrEmpty(s))
            return new List<int>();
        
        // Find last occurrence of each character
        var lastOccurrence = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            lastOccurrence[s[i]] = i;
        }
        
        var result = new List<int>();
        int start = 0;
        int end = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            end = Math.Max(end, lastOccurrence[s[i]]);
            
            if (i == end)
            {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }
        
        return result;
    }
    
    // Gas Station Problem
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        if (gas == null || cost == null || gas.Length == 0)
            return -1;
        
        int totalGas = 0;
        int currentGas = 0;
        int startStation = 0;
        
        for (int i = 0; i < gas.Length; i++)
        {
            int diff = gas[i] - cost[i];
            totalGas += diff;
            currentGas += diff;
            
            if (currentGas < 0)
            {
                currentGas = 0;
                startStation = i + 1;
            }
        }
        
        return totalGas >= 0 ? startStation : -1;
    }
    
    // Jump Game
    public bool CanJump(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return false;
        
        int maxReach = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > maxReach)
                return false;
            
            maxReach = Math.Max(maxReach, i + nums[i]);
            
            if (maxReach >= nums.Length - 1)
                return true;
        }
        
        return false;
    }
    
    // Jump Game II - Minimum jumps
    public int Jump(int[] nums)
    {
        if (nums == null || nums.Length <= 1)
            return 0;
        
        int jumps = 0;
        int currentEnd = 0;
        int farthest = 0;
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);
            
            if (i == currentEnd)
            {
                jumps++;
                currentEnd = farthest;
            }
        }
        
        return jumps;
    }
    
    // Assign Cookies
    public int FindContentChildren(int[] g, int[] s)
    {
        if (g == null || s == null || g.Length == 0 || s.Length == 0)
            return 0;
        
        Array.Sort(g);
        Array.Sort(s);
        
        int contentChildren = 0;
        int cookieIndex = 0;
        
        for (int i = 0; i < g.Length && cookieIndex < s.Length; i++)
        {
            while (cookieIndex < s.Length && s[cookieIndex] < g[i])
            {
                cookieIndex++;
            }
            
            if (cookieIndex < s.Length)
            {
                contentChildren++;
                cookieIndex++;
            }
        }
        
        return contentChildren;
    }
    
    // Task Scheduler
    public int LeastInterval(char[] tasks, int n)
    {
        if (tasks == null || tasks.Length == 0)
            return 0;
        
        // Count frequency of each task
        var taskCount = new int[26];
        foreach (char task in tasks)
        {
            taskCount[task - 'A']++;
        }
        
        // Find maximum frequency
        int maxFreq = taskCount.Max();
        int maxFreqCount = taskCount.Count(x => x == maxFreq);
        
        // Calculate minimum intervals needed
        int minIntervals = (maxFreq - 1) * (n + 1) + maxFreqCount;
        
        return Math.Max(minIntervals, tasks.Length);
    }
    
    // Minimum Number of Coins
    public int CoinChange(int[] coins, int amount)
    {
        if (coins == null || coins.Length == 0 || amount < 0)
            return -1;
        
        Array.Sort(coins);
        int coinCount = 0;
        int remaining = amount;
        
        for (int i = coins.Length - 1; i >= 0; i--)
        {
            if (remaining >= coins[i])
            {
                int count = remaining / coins[i];
                coinCount += count;
                remaining %= coins[i];
            }
        }
        
        return remaining == 0 ? coinCount : -1;
    }
    
    // Fractional Knapsack
    public double FractionalKnapsack(int[] weights, int[] values, int capacity)
    {
        if (weights == null || values == null || weights.Length == 0)
            return 0;
        
        // Create items with value per unit weight
        var items = new List<(double valuePerUnit, int weight, int value)>();
        for (int i = 0; i < weights.Length; i++)
        {
            items.Add((values[i] / (double)weights[i], weights[i], values[i]));
        }
        
        // Sort by value per unit weight (descending)
        items.Sort((a, b) => b.valuePerUnit.CompareTo(a.valuePerUnit));
        
        double totalValue = 0;
        int remainingCapacity = capacity;
        
        foreach (var item in items)
        {
            if (remainingCapacity >= item.weight)
            {
                totalValue += item.value;
                remainingCapacity -= item.weight;
            }
            else
            {
                totalValue += item.valuePerUnit * remainingCapacity;
                break;
            }
        }
        
        return totalValue;
    }
    
    // Huffman Coding (simplified)
    public class HuffmanNode
    {
        public char character;
        public int frequency;
        public HuffmanNode left, right;
        
        public HuffmanNode(char character, int frequency)
        {
            this.character = character;
            this.frequency = frequency;
        }
    }
    
    public HuffmanNode BuildHuffmanTree(char[] characters, int[] frequencies)
    {
        if (characters == null || frequencies == null || characters.Length == 0)
            return null;
        
        var minHeap = new SortedSet<HuffmanNode>(
            Comparer<HuffmanNode>.Create((a, b) => 
            {
                if (a.frequency != b.frequency)
                    return a.frequency.CompareTo(b.frequency);
                return a.character.CompareTo(b.character);
            }));
        
        // Add all characters to min heap
        for (int i = 0; i < characters.Length; i++)
        {
            minHeap.Add(new HuffmanNode(characters[i], frequencies[i]));
        }
        
        // Build tree by combining two minimum nodes
        while (minHeap.Count > 1)
        {
            var left = minHeap.Min;
            minHeap.Remove(left);
            
            var right = minHeap.Min;
            minHeap.Remove(right);
            
            var parent = new HuffmanNode('\0', left.frequency + right.frequency)
            {
                left = left,
                right = right
            };
            
            minHeap.Add(parent);
        }
        
        return minHeap.Count > 0 ? minHeap.Min : null;
    }
    
    // Utility method to print array
    public void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
    
    // Utility method to print 2D array
    public void Print2DArray(int[][] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"[{arr[i][0]}, {arr[i][1]}]");
            if (i < arr.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
    
    // Utility method to print list
    public void PrintList(List<int> list)
    {
        Console.Write("[");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
            if (i < list.Count - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
} 