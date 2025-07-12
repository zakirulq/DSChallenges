# Merge Sort (Divide and Conquer)

## Problem Statement

Implement Merge Sort algorithm to sort an array of integers in ascending order.

Merge Sort is a divide-and-conquer algorithm that recursively breaks down a problem into two or more sub-problems of the same or related type, until these become simple enough to be solved directly.

## Algorithm Steps

1. **Divide:** Split the array into two halves
2. **Conquer:** Recursively sort the two halves
3. **Merge:** Merge the sorted halves to produce the final sorted array

## Examples

### Example 1:
**Input:** `arr = [64, 34, 25, 12, 22, 11, 90]`  
**Output:** `[11, 12, 22, 25, 34, 64, 90]`

### Example 2:
**Input:** `arr = [5, 2, 4, 6, 1, 3]`  
**Output:** `[1, 2, 3, 4, 5, 6]`

### Example 3:
**Input:** `arr = [1]`  
**Output:** `[1]`

## Approach
1. **Base Case:** If array has 1 or fewer elements, return as is
2. **Divide:** Find the middle point and split array into two halves
3. **Conquer:** Recursively sort left and right halves
4. **Merge:** Combine the sorted halves into a single sorted array

## Time Complexity
- **Time:** O(n log n) - always
- **Space:** O(n) - auxiliary space for merging

## Advantages
- **Stable Sort:** Maintains relative order of equal elements
- **Predictable Performance:** Always O(n log n) regardless of input
- **Suitable for:** Large datasets, external sorting

## Disadvantages
- **Space Complexity:** Requires O(n) extra space
- **Not In-Place:** Cannot sort in-place like Quick Sort

## Test Cases

| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `[64, 34, 25, 12, 22, 11, 90]` | `[11, 12, 22, 25, 34, 64, 90]` | General case |
| `[5, 2, 4, 6, 1, 3]` | `[1, 2, 3, 4, 5, 6]` | Small array |
| `[1]` | `[1]` | Single element |
| `[3, 1, 4, 1, 5, 9, 2, 6]` | `[1, 1, 2, 3, 4, 5, 6, 9]` | Array with duplicates |
| `[9, 8, 7, 6, 5, 4, 3, 2, 1]` | `[1, 2, 3, 4, 5, 6, 7, 8, 9]` | Reverse sorted |
| `[1, 2, 3, 4, 5]` | `[1, 2, 3, 4, 5]` | Already sorted | 