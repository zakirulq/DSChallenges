# Sorting-Based Patterns

## Problem Statement

Sorting is a fundamental algorithmic technique that arranges elements in a specific order. Many problems can be solved efficiently by first sorting the data, then applying specific algorithms.

## Common Sorting Algorithms

### 1. Bubble Sort
**Problem:** Sort an array using bubble sort algorithm.

**Example:**
```
Input: arr = [64, 34, 25, 12, 22, 11, 90]
Output: [11, 12, 22, 25, 34, 64, 90]
```

### 2. Quick Sort
**Problem:** Sort an array using quick sort algorithm.

**Example:**
```
Input: arr = [64, 34, 25, 12, 22, 11, 90]
Output: [11, 12, 22, 25, 34, 64, 90]
```

### 3. Merge Sort
**Problem:** Sort an array using merge sort algorithm.

**Example:**
```
Input: arr = [64, 34, 25, 12, 22, 11, 90]
Output: [11, 12, 22, 25, 34, 64, 90]
```

## Sorting-Based Problem Solving

### 1. Two Sum (using sorting)
**Problem:** Given an array of integers and a target, find two numbers that add up to target using sorting approach.

**Example:**
```
Input: nums = [2, 7, 11, 15], target = 9
Output: [0, 1]
Explanation: After sorting, use two pointers to find the pair.
```

### 2. Three Sum
**Problem:** Given an array of integers, find all unique triplets that sum to zero.

**Example:**
```
Input: nums = [-1, 0, 1, 2, -1, -4]
Output: [[-1,-1,2], [-1,0,1]]
Explanation: Sort first, then use two pointers for each element.
```

### 3. Kth Largest Element
**Problem:** Find the kth largest element in an unsorted array.

**Example:**
```
Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Explanation: After sorting, the 2nd largest element is 5.
```

### 4. Meeting Rooms
**Problem:** Given an array of meeting time intervals, determine if a person could attend all meetings.

**Example:**
```
Input: intervals = [[0,30],[5,10],[15,20]]
Output: false
Explanation: Sort by start time, then check for overlaps.
```

### 5. Sort Colors (Dutch National Flag)
**Problem:** Sort an array containing only 0s, 1s, and 2s in-place.

**Example:**
```
Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]
Explanation: Use three pointers to partition the array.
```

## Time Complexity Comparison

| Algorithm | Best Case | Average Case | Worst Case | Space |
|-----------|-----------|--------------|------------|-------|
| Bubble Sort | O(n) | O(n²) | O(n²) | O(1) |
| Selection Sort | O(n²) | O(n²) | O(n²) | O(1) |
| Insertion Sort | O(n) | O(n²) | O(n²) | O(1) |
| Quick Sort | O(n log n) | O(n log n) | O(n²) | O(log n) |
| Merge Sort | O(n log n) | O(n log n) | O(n log n) | O(n) |
| Heap Sort | O(n log n) | O(n log n) | O(n log n) | O(1) |
| Counting Sort | O(n + k) | O(n + k) | O(n + k) | O(k) |
| Radix Sort | O(d(n + k)) | O(d(n + k)) | O(d(n + k)) | O(n + k) |

## Test Cases

### Basic Sorting:
| Input | Expected Output | Algorithm |
|-------|----------------|-----------|
| `[64, 34, 25, 12, 22, 11, 90]` | `[11, 12, 22, 25, 34, 64, 90]` | All sorting algorithms |
| `[5, 2, 4, 6, 1, 3]` | `[1, 2, 3, 4, 5, 6]` | All sorting algorithms |
| `[1]` | `[1]` | All sorting algorithms |

### Sorting-Based Problems:
| Input | Expected Output | Problem Type |
|-------|----------------|--------------|
| `nums=[2,7,11,15], target=9` | `[0,1]` | Two Sum with sorting |
| `nums=[-1,0,1,2,-1,-4]` | `[[-1,-1,2],[-1,0,1]]` | Three Sum |
| `nums=[3,2,1,5,6,4], k=2` | `5` | Kth Largest Element |
| `intervals=[[0,30],[5,10],[15,20]]` | `false` | Meeting Rooms |
| `nums=[2,0,2,1,1,0]` | `[0,0,1,1,2,2]` | Sort Colors | 