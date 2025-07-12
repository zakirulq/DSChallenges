# Sliding Window Problems

## Problem Statement

The Sliding Window technique is used to solve problems involving arrays/strings where we need to find/calculate something among all subarrays/substrings of a certain size or satisfying certain conditions.

## Common Sliding Window Problems

### 1. Maximum Sum Subarray of Size K
**Problem:** Given an array of integers and a positive integer k, find the maximum sum of any contiguous subarray of size k.

**Example:**
```
Input: nums = [1,4,2,10,2,3,1,0,20], k = 4
Output: 24
Explanation: Subarray [2,10,2,3] has maximum sum 24.
```

### 2. Longest Substring Without Repeating Characters
**Problem:** Given a string s, find the length of the longest substring without repeating characters.

**Example:**
```
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
```

### 3. Minimum Window Substring
**Problem:** Given two strings s and t, return the minimum window in s which will contain all the characters in t.

**Example:**
```
Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
```

### 4. Longest Substring with At Most K Distinct Characters
**Problem:** Given a string s and an integer k, return the length of the longest substring that contains at most k distinct characters.

**Example:**
```
Input: s = "eceba", k = 2
Output: 3
Explanation: The substring is "ece" with length 3.
```

### 5. Permutation in String
**Problem:** Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

**Example:**
```
Input: s1 = "ab", s2 = "eidbaooo"
Output: true
Explanation: s2 contains one permutation of s1 ("ba").
```

## Approach

### Fixed Size Window:
1. **Initialize:** Calculate sum of first k elements
2. **Slide:** Remove first element, add next element
3. **Update:** Keep track of maximum/minimum

### Variable Size Window:
1. **Expand:** Add elements to window
2. **Contract:** Remove elements when condition violated
3. **Track:** Keep track of best answer

## Time Complexity
- **Time:** O(n) - each element visited at most twice
- **Space:** O(k) - hash map for character count

## Test Cases

### Fixed Size Window:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[1,4,2,10,2,3,1,0,20], k=4` | `24` | Maximum sum of size 4 |
| `nums=[1,2,3,4,5], k=2` | `9` | Maximum sum of size 2 |

### Variable Size Window:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `s="abcabcbb"` | `3` | Longest substring without repeats |
| `s="bbbbb"` | `1` | All characters same |
| `s="pwwkew"` | `3` | "wke" is longest unique substring |

### String Problems:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `s="ADOBECODEBANC", t="ABC"` | `"BANC"` | Minimum window containing all chars |
| `s="eceba", k=2` | `3` | Longest substring with 2 distinct chars |
| `s1="ab", s2="eidbaooo"` | `true` | Permutation found in s2 | 