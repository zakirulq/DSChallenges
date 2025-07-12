# Binary Search and Variants

## Problem Statement

Binary Search is a search algorithm that finds the position of a target value within a sorted array. It compares the target value to the middle element of the array and eliminates half of the remaining elements in each iteration.

## Common Binary Search Problems

### 1. Standard Binary Search
**Problem:** Given a sorted array of integers `nums` and a target value, return the index if the target is found. If not, return -1.

**Example:**
```
Input: nums = [1,3,5,7,9,11,13,15], target = 7
Output: 3
Explanation: 7 exists in nums and its index is 3.
```

### 2. Find First Occurrence
**Problem:** Given a sorted array with duplicates, find the first occurrence of target.

**Example:**
```
Input: nums = [1,2,2,2,3,4,5], target = 2
Output: 1
Explanation: First occurrence of 2 is at index 1.
```

### 3. Find Last Occurrence
**Problem:** Given a sorted array with duplicates, find the last occurrence of target.

**Example:**
```
Input: nums = [1,2,2,2,3,4,5], target = 2
Output: 3
Explanation: Last occurrence of 2 is at index 3.
```

### 4. Search in Rotated Sorted Array
**Problem:** Given a sorted array that has been rotated, find target.

**Example:**
```
Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Explanation: 0 exists in nums and its index is 4.
```

### 5. Find Peak Element
**Problem:** Find a peak element in an array (element greater than its neighbors).

**Example:**
```
Input: nums = [1,2,3,1]
Output: 2
Explanation: 3 is a peak element and its index is 2.
```

## Approach

### Standard Binary Search:
1. **Initialize:** left = 0, right = length - 1
2. **Loop:** while left <= right
3. **Calculate:** mid = left + (right - left) / 2
4. **Compare:** nums[mid] with target
5. **Update:** left or right based on comparison

### Variants:
- **First Occurrence:** When found, continue searching left
- **Last Occurrence:** When found, continue searching right
- **Ceiling:** Find smallest element >= target
- **Floor:** Find largest element <= target

## Time Complexity
- **Time:** O(log n) - eliminates half elements each iteration
- **Space:** O(1) - constant extra space

## Test Cases

### Standard Binary Search:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[1,3,5,7,9,11,13,15], target=7` | `3` | Found at index 3 |
| `nums=[1,3,5,7,9,11,13,15], target=10` | `-1` | Not found |
| `nums=[1], target=1` | `0` | Single element |

### First/Last Occurrence:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[1,2,2,2,3,4,5], target=2` | `1` (first), `3` (last) | Multiple occurrences |
| `nums=[1,2,3,4,5], target=3` | `2` (both) | Single occurrence |

### Rotated Array:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[4,5,6,7,0,1,2], target=0` | `4` | Found in rotated array |
| `nums=[4,5,6,7,0,1,2], target=3` | `-1` | Not found | 