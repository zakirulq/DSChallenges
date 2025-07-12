# Prefix Sum Problems

## Problem Statement

Prefix Sum (also known as Cumulative Sum) is a technique that allows us to calculate the sum of any subarray in O(1) time after O(n) preprocessing. It's particularly useful for range sum queries and related problems.

## Common Prefix Sum Problems

### 1. Range Sum Query
**Problem:** Given an array and multiple queries asking for sum of subarrays, answer each query efficiently.

**Example:**
```
Input: nums = [1,2,3,4,5], queries = [[1,3], [0,4]]
Output: [9, 15]
Explanation: Sum from index 1 to 3 is 2+3+4=9, sum from 0 to 4 is 1+2+3+4+5=15
```

### 2. Subarray Sum Equals K
**Problem:** Given an array of integers and an integer k, find the total number of continuous subarrays whose sum equals to k.

**Example:**
```
Input: nums = [1,1,1], k = 2
Output: 2
Explanation: [1,1] and [1,1] are the two subarrays with sum 2.
```

### 3. Maximum Subarray Sum
**Problem:** Find the contiguous subarray with the largest sum.

**Example:**
```
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
```

### 4. Maximum Subarray Sum with Size K
**Problem:** Find the maximum sum of a subarray of size k.

**Example:**
```
Input: nums = [1,4,2,10,2,3,1,0,20], k = 4
Output: 24
Explanation: Subarray [2,10,2,3] has maximum sum 24.
```

## Approach

### Prefix Sum Construction:
1. **Initialize:** prefixSum[0] = 0
2. **Calculate:** prefixSum[i] = prefixSum[i-1] + nums[i-1]
3. **Query:** sum(i,j) = prefixSum[j+1] - prefixSum[i]

### Key Techniques:
- **Range Sum:** Use prefix sum difference
- **Subarray Count:** Use hash map to track prefix sums
- **Maximum Sum:** Track minimum prefix sum seen so far

## Time Complexity
- **Preprocessing:** O(n) - build prefix sum array
- **Query:** O(1) - constant time range sum
- **Space:** O(n) - prefix sum array

## Test Cases

### Range Sum Query:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[1,2,3,4,5], query=[1,3]` | `9` | Sum of [2,3,4] |
| `nums=[1,2,3,4,5], query=[0,4]` | `15` | Sum of entire array |
| `nums=[1,2,3,4,5], query=[2,2]` | `3` | Single element |

### Subarray Sum Equals K:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[1,1,1], k=2` | `2` | Two subarrays with sum 2 |
| `nums=[1,2,3], k=3` | `2` | [1,2] and [3] |
| `nums=[1,2,3,4,5], k=9` | `2` | [2,3,4] and [4,5] |

### Maximum Subarray Sum:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[-2,1,-3,4,-1,2,1,-5,4]` | `6` | [4,-1,2,1] |
| `nums=[-1,-2,-3]` | `-1` | Single element [-1] |
| `nums=[1,2,3,4,5]` | `15` | Entire array | 