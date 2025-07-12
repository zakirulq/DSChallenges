using System;
using System.Collections.Generic;

namespace SlidingWindow
{
    public class SlidingWindowTest
    {
        public static void TestSlidingWindow()
        {
            Console.WriteLine("--- Testing Sliding Window Problems ---");
            SlidingWindowSolution sol = new SlidingWindowSolution();

            // Test 1: Fixed Size Window - Maximum Sum
            Console.WriteLine("1. Testing Fixed Size Window - Maximum Sum:");
            int[] nums1 = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
            int k1 = 4;
            Console.Write("Array: ");
            sol.PrintArray(nums1);
            Console.WriteLine($"Window size: {k1}");
            
            int maxSum1 = sol.MaxSumFixedWindow(nums1, k1);
            Console.WriteLine($"Maximum sum of subarray with size {k1}: {maxSum1}");
            // Expected: 24

            // Test 2: Variable Size Window - Longest Subarray with Sum At Most K
            Console.WriteLine("\n2. Testing Variable Size Window - Longest Subarray with Sum At Most K:");
            int[] nums2 = { 1, 2, 3, 4, 5 };
            int k2 = 10;
            Console.Write("Array: ");
            sol.PrintArray(nums2);
            Console.WriteLine($"Target sum: {k2}");
            
            int maxLength2 = sol.LongestSubarraySumAtMostK(nums2, k2);
            Console.WriteLine($"Longest subarray length with sum at most {k2}: {maxLength2}");
            // Expected: 4

            // Test 3: Longest Substring Without Repeating Characters
            Console.WriteLine("\n3. Testing Longest Substring Without Repeating Characters:");
            string s3 = "abcabcbb";
            Console.WriteLine($"String: \"{s3}\"");
            
            int maxLength3 = sol.LengthOfLongestSubstring(s3);
            Console.WriteLine($"Longest substring without repeating characters: {maxLength3}");
            // Expected: 3

            string s3b = "bbbbb";
            Console.WriteLine($"String: \"{s3b}\"");
            
            int maxLength3b = sol.LengthOfLongestSubstring(s3b);
            Console.WriteLine($"Longest substring without repeating characters: {maxLength3b}");
            // Expected: 1

            // Test 4: Minimum Window Substring
            Console.WriteLine("\n4. Testing Minimum Window Substring:");
            string s4 = "ADOBECODEBANC";
            string t4 = "ABC";
            Console.WriteLine($"String: \"{s4}\"");
            Console.WriteLine($"Target: \"{t4}\"");
            
            string minWindow4 = sol.MinWindow(s4, t4);
            Console.WriteLine($"Minimum window: \"{minWindow4}\"");
            // Expected: "BANC"

            // Test 5: Longest Substring with At Most K Distinct Characters
            Console.WriteLine("\n5. Testing Longest Substring with At Most K Distinct Characters:");
            string s5 = "eceba";
            int k5 = 2;
            Console.WriteLine($"String: \"{s5}\"");
            Console.WriteLine($"k = {k5}");
            
            int maxLength5 = sol.LengthOfLongestSubstringKDistinct(s5, k5);
            Console.WriteLine($"Longest substring with at most {k5} distinct characters: {maxLength5}");
            // Expected: 3

            // Test 6: Longest Substring with At Most Two Distinct Characters
            Console.WriteLine("\n6. Testing Longest Substring with At Most Two Distinct Characters:");
            string s6 = "eceba";
            Console.WriteLine($"String: \"{s6}\"");
            
            int maxLength6 = sol.LengthOfLongestSubstringTwoDistinct(s6);
            Console.WriteLine($"Longest substring with at most 2 distinct characters: {maxLength6}");
            // Expected: 3

            // Test 7: Maximum Number of Vowels in a Substring
            Console.WriteLine("\n7. Testing Maximum Number of Vowels in a Substring:");
            string s7 = "abciiidef";
            int k7 = 3;
            Console.WriteLine($"String: \"{s7}\"");
            Console.WriteLine($"Window size: {k7}");
            
            int maxVowels7 = sol.MaxVowels(s7, k7);
            Console.WriteLine($"Maximum number of vowels in substring of size {k7}: {maxVowels7}");
            // Expected: 3

            // Test 8: Permutation in String
            Console.WriteLine("\n8. Testing Permutation in String:");
            string s8_1 = "ab";
            string s8_2 = "eidbaooo";
            Console.WriteLine($"s1: \"{s8_1}\", s2: \"{s8_2}\"");
            
            bool hasPermutation8 = sol.CheckInclusion(s8_1, s8_2);
            Console.WriteLine($"s2 contains permutation of s1: {hasPermutation8}");
            // Expected: true

            string s8_1b = "ab";
            string s8_2b = "eidboaoo";
            Console.WriteLine($"s1: \"{s8_1b}\", s2: \"{s8_2b}\"");
            
            bool hasPermutation8b = sol.CheckInclusion(s8_1b, s8_2b);
            Console.WriteLine($"s2 contains permutation of s1: {hasPermutation8b}");
            // Expected: false

            // Test 9: Find All Anagrams in a String
            Console.WriteLine("\n9. Testing Find All Anagrams in a String:");
            string s9 = "cbaebabacd";
            string p9 = "abc";
            Console.WriteLine($"String: \"{s9}\"");
            Console.WriteLine($"Pattern: \"{p9}\"");
            
            List<int> anagramIndices9 = sol.FindAnagrams(s9, p9);
            Console.Write("Anagram starting indices: ");
            sol.PrintList(anagramIndices9);
            // Expected: [0, 6]

            // Test 10: Maximum Sum of Two Non-Overlapping Subarrays
            Console.WriteLine("\n10. Testing Maximum Sum of Two Non-Overlapping Subarrays:");
            int[] nums10 = { 0, 6, 5, 2, 2, 5, 1, 9, 4 };
            int firstLen10 = 1, secondLen10 = 2;
            Console.Write("Array: ");
            sol.PrintArray(nums10);
            Console.WriteLine($"First length: {firstLen10}, Second length: {secondLen10}");
            
            int maxSum10 = sol.MaxSumTwoNoOverlap(nums10, firstLen10, secondLen10);
            Console.WriteLine($"Maximum sum of two non-overlapping subarrays: {maxSum10}");
            // Expected: 20
            Console.WriteLine();
        }
    }
} 