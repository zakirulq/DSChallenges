using System;

public class GreedyTest
{
    public static void TestGreedy()
    {
        Console.WriteLine("--- Testing Greedy Algorithms and Interval Partitioning ---");
        GreedySolution sol = new GreedySolution();

        // Test 1: Activity Selection Problem
        Console.WriteLine("1. Testing Activity Selection Problem:");
        int[] start1 = { 1, 3, 0, 5, 8, 5 };
        int[] end1 = { 2, 4, 6, 7, 9, 9 };
        Console.Write("Start times: ");
        sol.PrintArray(start1);
        Console.Write("End times: ");
        sol.PrintArray(end1);
        
        int maxActivities1 = sol.ActivitySelection(start1, end1);
        Console.WriteLine($"Maximum number of activities: {maxActivities1}");
        // Expected: 4

        // Test 2: Minimum Number of Arrows to Burst Balloons
        Console.WriteLine("\n2. Testing Minimum Number of Arrows to Burst Balloons:");
        int[][] balloons1 = {
            new int[] { 10, 16 },
            new int[] { 2, 8 },
            new int[] { 1, 6 },
            new int[] { 7, 12 }
        };
        Console.Write("Balloons: ");
        sol.Print2DArray(balloons1);
        
        int arrows1 = sol.FindMinArrowShots(balloons1);
        Console.WriteLine($"Minimum arrows needed: {arrows1}");
        // Expected: 2

        // Test 3: Non-overlapping Intervals
        Console.WriteLine("\n3. Testing Non-overlapping Intervals:");
        int[][] intervals1 = {
            new int[] { 1, 2 },
            new int[] { 2, 3 },
            new int[] { 3, 4 },
            new int[] { 1, 3 }
        };
        Console.Write("Intervals: ");
        sol.Print2DArray(intervals1);
        
        int removedIntervals1 = sol.EraseOverlapIntervals(intervals1);
        Console.WriteLine($"Minimum intervals to remove: {removedIntervals1}");
        // Expected: 1

        // Test 4: Partition Labels
        Console.WriteLine("\n4. Testing Partition Labels:");
        string s4 = "ababcbacadefegdehijhklij";
        Console.WriteLine($"String: \"{s4}\"");
        
        var partitionSizes4 = sol.PartitionLabels(s4);
        Console.Write("Partition sizes: ");
        sol.PrintList(partitionSizes4);
        // Expected: [9, 7, 8]

        // Test 5: Gas Station Problem
        Console.WriteLine("\n5. Testing Gas Station Problem:");
        int[] gas1 = { 1, 2, 3, 4, 5 };
        int[] cost1 = { 3, 4, 5, 1, 2 };
        Console.Write("Gas: ");
        sol.PrintArray(gas1);
        Console.Write("Cost: ");
        sol.PrintArray(cost1);
        
        int startStation1 = sol.CanCompleteCircuit(gas1, cost1);
        Console.WriteLine($"Starting gas station: {startStation1}");
        // Expected: 3

        // Test 6: Jump Game
        Console.WriteLine("\n6. Testing Jump Game:");
        int[] nums6 = { 2, 3, 1, 1, 4 };
        Console.Write("Array: ");
        sol.PrintArray(nums6);
        
        bool canJump6 = sol.CanJump(nums6);
        Console.WriteLine($"Can reach the end: {canJump6}");
        // Expected: true

        int[] nums6b = { 3, 2, 1, 0, 4 };
        Console.Write("Array: ");
        sol.PrintArray(nums6b);
        
        bool canJump6b = sol.CanJump(nums6b);
        Console.WriteLine($"Can reach the end: {canJump6b}");
        // Expected: false

        // Test 7: Jump Game II - Minimum jumps
        Console.WriteLine("\n7. Testing Jump Game II - Minimum jumps:");
        int[] nums7 = { 2, 3, 1, 1, 4 };
        Console.Write("Array: ");
        sol.PrintArray(nums7);
        
        int minJumps7 = sol.Jump(nums7);
        Console.WriteLine($"Minimum jumps needed: {minJumps7}");
        // Expected: 2

        // Test 8: Assign Cookies
        Console.WriteLine("\n8. Testing Assign Cookies:");
        int[] children8 = { 1, 2, 3 };
        int[] cookies8 = { 1, 1 };
        Console.Write("Children's greed factors: ");
        sol.PrintArray(children8);
        Console.Write("Cookie sizes: ");
        sol.PrintArray(cookies8);
        
        int contentChildren8 = sol.FindContentChildren(children8, cookies8);
        Console.WriteLine($"Content children: {contentChildren8}");
        // Expected: 1

        // Test 9: Task Scheduler
        Console.WriteLine("\n9. Testing Task Scheduler:");
        char[] tasks9 = { 'A', 'A', 'A', 'B', 'B', 'B' };
        int n9 = 2;
        Console.Write("Tasks: ");
        Console.WriteLine($"['{string.Join("', '", tasks9)}']");
        Console.WriteLine($"Cooldown period: {n9}");
        
        int minIntervals9 = sol.LeastInterval(tasks9, n9);
        Console.WriteLine($"Minimum intervals needed: {minIntervals9}");
        // Expected: 8

        // Test 10: Minimum Number of Coins
        Console.WriteLine("\n10. Testing Minimum Number of Coins:");
        int[] coins10 = { 1, 2, 5 };
        int amount10 = 11;
        Console.Write("Coins: ");
        sol.PrintArray(coins10);
        Console.WriteLine($"Amount: {amount10}");
        
        int coinCount10 = sol.CoinChange(coins10, amount10);
        Console.WriteLine($"Minimum coins needed: {coinCount10}");
        // Expected: 3

        // Test 11: Fractional Knapsack
        Console.WriteLine("\n11. Testing Fractional Knapsack:");
        int[] weights11 = { 10, 20, 30 };
        int[] values11 = { 60, 100, 120 };
        int capacity11 = 50;
        Console.Write("Weights: ");
        sol.PrintArray(weights11);
        Console.Write("Values: ");
        sol.PrintArray(values11);
        Console.WriteLine($"Capacity: {capacity11}");
        
        double maxValue11 = sol.FractionalKnapsack(weights11, values11, capacity11);
        Console.WriteLine($"Maximum value: {maxValue11}");
        // Expected: 240.0

        // Test 12: Huffman Coding
        Console.WriteLine("\n12. Testing Huffman Coding:");
        char[] characters12 = { 'a', 'b', 'c', 'd', 'e' };
        int[] frequencies12 = { 5, 9, 12, 13, 16 };
        Console.Write("Characters: ");
        Console.WriteLine($"['{string.Join("', '", characters12)}']");
        Console.Write("Frequencies: ");
        sol.PrintArray(frequencies12);
        
        var huffmanTree = sol.BuildHuffmanTree(characters12, frequencies12);
        Console.WriteLine($"Huffman tree built successfully: {huffmanTree != null}");
        // Expected: true
        Console.WriteLine();
    }
} 