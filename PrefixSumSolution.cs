using System;

public class PrefixSumSolution
{
    // Basic Prefix Sum - Calculate prefix sum array
    public int[] CalculatePrefixSum(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return new int[0];
        
        int[] prefixSum = new int[nums.Length + 1];
        prefixSum[0] = 0; // Base case
        
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
        
        return prefixSum;
    }
    
    // Range Sum Query - Get sum from index left to right (inclusive)
    public int RangeSumQuery(int[] prefixSum, int left, int right)
    {
        if (prefixSum == null || left < 0 || right >= prefixSum.Length - 1 || left > right)
            return 0;
        
        return prefixSum[right + 1] - prefixSum[left];
    }
    
    // Subarray Sum Equals K - Count number of subarrays with sum K
    public int SubarraySumEqualsK(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        
        int count = 0;
        int sum = 0;
        var sumCount = new System.Collections.Generic.Dictionary<int, int>();
        sumCount[0] = 1; // Base case: empty subarray has sum 0
        
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            
            // If we've seen (sum - k) before, we found a subarray with sum k
            if (sumCount.ContainsKey(sum - k))
                count += sumCount[sum - k];
            
            // Update the count of current sum
            if (sumCount.ContainsKey(sum))
                sumCount[sum]++;
            else
                sumCount[sum] = 1;
        }
        
        return count;
    }
    
    // Maximum Subarray Sum
    public int MaxSubArraySum(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        
        int maxSum = nums[0];
        int currentSum = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        return maxSum;
    }
    
    // Maximum Subarray Sum with Size K
    public int MaxSubArraySumSizeK(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0 || k > nums.Length)
            return 0;
        
        // Calculate sum of first window
        int windowSum = 0;
        for (int i = 0; i < k; i++)
        {
            windowSum += nums[i];
        }
        
        int maxSum = windowSum;
        
        // Slide the window
        for (int i = k; i < nums.Length; i++)
        {
            windowSum = windowSum - nums[i - k] + nums[i];
            maxSum = Math.Max(maxSum, windowSum);
        }
        
        return maxSum;
    }
    
    // Minimum Subarray Sum with Size K
    public int MinSubArraySumSizeK(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0 || k > nums.Length)
            return 0;
        
        // Calculate sum of first window
        int windowSum = 0;
        for (int i = 0; i < k; i++)
        {
            windowSum += nums[i];
        }
        
        int minSum = windowSum;
        
        // Slide the window
        for (int i = k; i < nums.Length; i++)
        {
            windowSum = windowSum - nums[i - k] + nums[i];
            minSum = Math.Min(minSum, windowSum);
        }
        
        return minSum;
    }
    
    // Maximum Subarray Sum with At Most K Elements
    public int MaxSubArraySumAtMostK(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return 0;
        
        int maxSum = 0;
        int currentSum = 0;
        int start = 0;
        
        for (int end = 0; end < nums.Length; end++)
        {
            currentSum += nums[end];
            
            // Shrink window if it exceeds k elements
            while (end - start + 1 > k)
            {
                currentSum -= nums[start];
                start++;
            }
            
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        return maxSum;
    }
    
    // Count Subarrays with Sum in Range [lower, upper]
    public int CountSubarraysInRange(int[] nums, int lower, int upper)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        
        int count = 0;
        int sum = 0;
        var sumCount = new System.Collections.Generic.Dictionary<int, int>();
        sumCount[0] = 1;
        
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            
            // Count subarrays ending at i with sum in [lower, upper]
            for (int target = lower; target <= upper; target++)
            {
                if (sumCount.ContainsKey(sum - target))
                    count += sumCount[sum - target];
            }
            
            if (sumCount.ContainsKey(sum))
                sumCount[sum]++;
            else
                sumCount[sum] = 1;
        }
        
        return count;
    }
    
    // Maximum Sum of Two Non-Overlapping Subarrays
    public int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        
        int n = nums.Length;
        int[] prefixSum = CalculatePrefixSum(nums);
        
        int maxSum = 0;
        
        // Try first subarray before second subarray
        for (int i = 0; i <= n - firstLen - secondLen; i++)
        {
            int firstSum = RangeSumQuery(prefixSum, i, i + firstLen - 1);
            
            for (int j = i + firstLen; j <= n - secondLen; j++)
            {
                int secondSum = RangeSumQuery(prefixSum, j, j + secondLen - 1);
                maxSum = Math.Max(maxSum, firstSum + secondSum);
            }
        }
        
        // Try second subarray before first subarray
        for (int i = 0; i <= n - firstLen - secondLen; i++)
        {
            int secondSum = RangeSumQuery(prefixSum, i, i + secondLen - 1);
            
            for (int j = i + secondLen; j <= n - firstLen; j++)
            {
                int firstSum = RangeSumQuery(prefixSum, j, j + firstLen - 1);
                maxSum = Math.Max(maxSum, firstSum + secondSum);
            }
        }
        
        return maxSum;
    }
    
    // Maximum Sum of Three Non-Overlapping Subarrays
    public int[] MaxSumThreeNoOverlap(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return new int[0];
        
        int n = nums.Length;
        int[] prefixSum = CalculatePrefixSum(nums);
        
        int maxSum = 0;
        int[] result = new int[3];
        
        // Try all possible combinations of three non-overlapping subarrays
        for (int i = 0; i <= n - 3 * k; i++)
        {
            int sum1 = RangeSumQuery(prefixSum, i, i + k - 1);
            
            for (int j = i + k; j <= n - 2 * k; j++)
            {
                int sum2 = RangeSumQuery(prefixSum, j, j + k - 1);
                
                for (int l = j + k; l <= n - k; l++)
                {
                    int sum3 = RangeSumQuery(prefixSum, l, l + k - 1);
                    
                    if (sum1 + sum2 + sum3 > maxSum)
                    {
                        maxSum = sum1 + sum2 + sum3;
                        result[0] = i;
                        result[1] = j;
                        result[2] = l;
                    }
                }
            }
        }
        
        return result;
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
    
    // Utility method to print prefix sum array
    public void PrintPrefixSum(int[] prefixSum)
    {
        Console.Write("Prefix Sum: [");
        for (int i = 0; i < prefixSum.Length; i++)
        {
            Console.Write(prefixSum[i]);
            if (i < prefixSum.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
} 