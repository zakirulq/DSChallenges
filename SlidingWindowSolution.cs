using System;
using System.Collections.Generic;

public class SlidingWindowSolution
{
    // Fixed Size Window - Maximum Sum of Subarray of Size K
    public int MaxSumFixedWindow(int[] nums, int k)
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
    
    // Variable Size Window - Longest Subarray with Sum Less Than or Equal to K
    public int LongestSubarraySumAtMostK(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        
        int maxLength = 0;
        int windowSum = 0;
        int start = 0;
        
        for (int end = 0; end < nums.Length; end++)
        {
            windowSum += nums[end];
            
            // Shrink window if sum exceeds k
            while (windowSum > k && start <= end)
            {
                windowSum -= nums[start];
                start++;
            }
            
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        
        return maxLength;
    }
    
    // Longest Substring Without Repeating Characters
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        
        int maxLength = 0;
        int start = 0;
        var charSet = new HashSet<char>();
        
        for (int end = 0; end < s.Length; end++)
        {
            // Shrink window if character already exists
            while (charSet.Contains(s[end]))
            {
                charSet.Remove(s[start]);
                start++;
            }
            
            charSet.Add(s[end]);
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        
        return maxLength;
    }
    
    // Minimum Window Substring
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";
        
        var targetCount = new Dictionary<char, int>();
        var windowCount = new Dictionary<char, int>();
        
        // Count characters in target string
        foreach (char c in t)
        {
            if (targetCount.ContainsKey(c))
                targetCount[c]++;
            else
                targetCount[c] = 1;
        }
        
        int required = targetCount.Count;
        int formed = 0;
        int start = 0;
        int minLength = int.MaxValue;
        int minStart = 0;
        
        for (int end = 0; end < s.Length; end++)
        {
            char c = s[end];
            
            // Update window count
            if (windowCount.ContainsKey(c))
                windowCount[c]++;
            else
                windowCount[c] = 1;
            
            // Check if we have enough of this character
            if (targetCount.ContainsKey(c) && windowCount[c] == targetCount[c])
                formed++;
            
            // Try to shrink window
            while (formed == required)
            {
                if (end - start + 1 < minLength)
                {
                    minLength = end - start + 1;
                    minStart = start;
                }
                
                char startChar = s[start];
                windowCount[startChar]--;
                
                if (targetCount.ContainsKey(startChar) && windowCount[startChar] < targetCount[startChar])
                    formed--;
                
                start++;
            }
        }
        
        return minLength == int.MaxValue ? "" : s.Substring(minStart, minLength);
    }
    
    // Longest Substring with At Most K Distinct Characters
    public int LengthOfLongestSubstringKDistinct(string s, int k)
    {
        if (string.IsNullOrEmpty(s) || k <= 0)
            return 0;
        
        int maxLength = 0;
        int start = 0;
        var charCount = new Dictionary<char, int>();
        
        for (int end = 0; end < s.Length; end++)
        {
            char c = s[end];
            
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
            
            // Shrink window if we have more than k distinct characters
            while (charCount.Count > k)
            {
                char startChar = s[start];
                charCount[startChar]--;
                
                if (charCount[startChar] == 0)
                    charCount.Remove(startChar);
                
                start++;
            }
            
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        
        return maxLength;
    }
    
    // Longest Substring with At Most Two Distinct Characters
    public int LengthOfLongestSubstringTwoDistinct(string s)
    {
        return LengthOfLongestSubstringKDistinct(s, 2);
    }
    
    // Maximum Number of Vowels in a Substring of Given Length
    public int MaxVowels(string s, int k)
    {
        if (string.IsNullOrEmpty(s) || k <= 0)
            return 0;
        
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        
        // Count vowels in first window
        int vowelCount = 0;
        for (int i = 0; i < k; i++)
        {
            if (vowels.Contains(s[i]))
                vowelCount++;
        }
        
        int maxVowels = vowelCount;
        
        // Slide the window
        for (int i = k; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
                vowelCount++;
            if (vowels.Contains(s[i - k]))
                vowelCount--;
            
            maxVowels = Math.Max(maxVowels, vowelCount);
        }
        
        return maxVowels;
    }
    
    // Permutation in String (Check if s2 contains permutation of s1)
    public bool CheckInclusion(string s1, string s2)
    {
        if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || s1.Length > s2.Length)
            return false;
        
        var s1Count = new int[26];
        var s2Count = new int[26];
        
        // Count characters in s1
        foreach (char c in s1)
        {
            s1Count[c - 'a']++;
        }
        
        // Check first window
        for (int i = 0; i < s1.Length; i++)
        {
            s2Count[s2[i] - 'a']++;
        }
        
        if (ArraysEqual(s1Count, s2Count))
            return true;
        
        // Slide the window
        for (int i = s1.Length; i < s2.Length; i++)
        {
            s2Count[s2[i] - 'a']++;
            s2Count[s2[i - s1.Length] - 'a']--;
            
            if (ArraysEqual(s1Count, s2Count))
                return true;
        }
        
        return false;
    }
    
    // Find All Anagrams in a String
    public List<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();
        
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || p.Length > s.Length)
            return result;
        
        var pCount = new int[26];
        var sCount = new int[26];
        
        // Count characters in pattern
        foreach (char c in p)
        {
            pCount[c - 'a']++;
        }
        
        // Check first window
        for (int i = 0; i < p.Length; i++)
        {
            sCount[s[i] - 'a']++;
        }
        
        if (ArraysEqual(pCount, sCount))
            result.Add(0);
        
        // Slide the window
        for (int i = p.Length; i < s.Length; i++)
        {
            sCount[s[i] - 'a']++;
            sCount[s[i - p.Length] - 'a']--;
            
            if (ArraysEqual(pCount, sCount))
                result.Add(i - p.Length + 1);
        }
        
        return result;
    }
    
    // Maximum Sum of Two Non-Overlapping Subarrays
    public int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        
        int n = nums.Length;
        
        // Calculate prefix sum
        int[] prefixSum = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
        
        int maxSum = 0;
        
        // Try first subarray before second subarray
        for (int i = 0; i <= n - firstLen - secondLen; i++)
        {
            int firstSum = prefixSum[i + firstLen] - prefixSum[i];
            
            for (int j = i + firstLen; j <= n - secondLen; j++)
            {
                int secondSum = prefixSum[j + secondLen] - prefixSum[j];
                maxSum = Math.Max(maxSum, firstSum + secondSum);
            }
        }
        
        // Try second subarray before first subarray
        for (int i = 0; i <= n - firstLen - secondLen; i++)
        {
            int secondSum = prefixSum[i + secondLen] - prefixSum[i];
            
            for (int j = i + secondLen; j <= n - firstLen; j++)
            {
                int firstSum = prefixSum[j + firstLen] - prefixSum[j];
                maxSum = Math.Max(maxSum, firstSum + secondSum);
            }
        }
        
        return maxSum;
    }
    
    // Helper method to compare arrays
    private bool ArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            return false;
        
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        
        return true;
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