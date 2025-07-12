using System;
using System.Collections.Generic;
using System.Linq;

public class TopKFrequentSolution
{
    // Approach 1: Using Min Heap (Priority Queue)
    public int[] TopKFrequent(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return new int[0];
        
        // Count frequency of each element
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        
        // Use min heap to keep top k frequent elements
        var minHeap = new SortedDictionary<int, List<int>>();
        
        foreach (var kvp in frequency)
        {
            int num = kvp.Key;
            int freq = kvp.Value;
            
            if (minHeap.ContainsKey(freq))
                minHeap[freq].Add(num);
            else
                minHeap[freq] = new List<int> { num };
            
            // Keep only top k frequencies
            if (minHeap.Count > k)
            {
                var minFreq = minHeap.Keys.First();
                minHeap.Remove(minFreq);
            }
        }
        
        // Extract result from heap
        List<int> result = new List<int>();
        foreach (var kvp in minHeap.OrderByDescending(x => x.Key))
        {
            result.AddRange(kvp.Value);
            if (result.Count >= k)
                break;
        }
        
        return result.Take(k).ToArray();
    }
    
    // Approach 2: Using Bucket Sort (Most Efficient)
    public int[] TopKFrequentBucketSort(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return new int[0];
        
        // Count frequency of each element
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        
        // Create buckets: bucket[i] contains elements with frequency i
        List<int>[] buckets = new List<int>[nums.Length + 1];
        for (int i = 0; i < buckets.Length; i++)
            buckets[i] = new List<int>();
        
        foreach (var kvp in frequency)
        {
            int num = kvp.Key;
            int freq = kvp.Value;
            buckets[freq].Add(num);
        }
        
        // Extract top k elements from buckets (highest frequency first)
        List<int> result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            result.AddRange(buckets[i]);
        }
        
        return result.Take(k).ToArray();
    }
    
    // Approach 3: Using Quick Select (Lomuto's Partition)
    public int[] TopKFrequentQuickSelect(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return new int[0];
        
        // Count frequency of each element
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        
        // Convert to array of unique elements
        int[] uniqueNums = frequency.Keys.ToArray();
        
        // Quick select to find the kth most frequent element
        QuickSelect(uniqueNums, 0, uniqueNums.Length - 1, k, frequency);
        
        // Return top k elements
        return uniqueNums.Take(k).ToArray();
    }
    
    private void QuickSelect(int[] nums, int left, int right, int k, Dictionary<int, int> frequency)
    {
        if (left < right)
        {
            int pivotIndex = Partition(nums, left, right, frequency);
            
            if (pivotIndex == k - 1)
                return;
            else if (pivotIndex < k - 1)
                QuickSelect(nums, pivotIndex + 1, right, k, frequency);
            else
                QuickSelect(nums, left, pivotIndex - 1, k, frequency);
        }
    }
    
    private int Partition(int[] nums, int left, int right, Dictionary<int, int> frequency)
    {
        int pivot = frequency[nums[right]];
        int i = left - 1;
        
        for (int j = left; j < right; j++)
        {
            if (frequency[nums[j]] >= pivot)
            {
                i++;
                Swap(nums, i, j);
            }
        }
        
        Swap(nums, i + 1, right);
        return i + 1;
    }
    
    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    
    // Approach 4: Using LINQ (Simple but less efficient)
    public int[] TopKFrequentLinq(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return new int[0];
        
        return nums
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .Take(k)
            .Select(g => g.Key)
            .ToArray();
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
    
    // Utility method to print frequency map
    public void PrintFrequency(Dictionary<int, int> frequency)
    {
        Console.Write("Frequency map: {");
        foreach (var kvp in frequency.OrderBy(x => x.Key))
        {
            Console.Write($"{kvp.Key}:{kvp.Value}");
            if (kvp.Key != frequency.Keys.Max())
                Console.Write(", ");
        }
        Console.WriteLine("}");
    }
} 