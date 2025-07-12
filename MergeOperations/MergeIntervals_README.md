# Merge Intervals

## Problem Statement

Given an array of `intervals` where `intervals[i] = [starti, endi]`, merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

## Examples

### Example 1:
**Input:** `intervals = [[1,3],[2,6],[8,10],[15,18]]`  
**Output:** `[[1,6],[8,10],[15,18]]`  
**Explanation:** Since intervals [1,3] and [2,6] overlap, merge them into [1,6].

### Example 2:
**Input:** `intervals = [[1,4],[4,5]]`  
**Output:** `[[1,5]]`  
**Explanation:** Intervals [1,4] and [4,5] are considered overlapping.

### Example 3:
**Input:** `intervals = [[1,4],[0,4]]`  
**Output:** `[[0,4]]`  
**Explanation:** Intervals [1,4] and [0,4] overlap, merge into [0,4].

## Constraints
- `1 <= intervals.length <= 104`
- `intervals[i].length == 2`
- `0 <= starti <= endi <= 104`

## Approach
1. Sort the intervals by start time
2. Initialize result with first interval
3. For each subsequent interval:
   - If it overlaps with the last interval in result, merge them
   - If no overlap, add to result
4. Return the merged intervals

## Time Complexity
- **Time:** O(n log n) - sorting + linear scan
- **Space:** O(n) - output array

## Test Cases

| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `[[1,3],[2,6],[8,10],[15,18]]` | `[[1,6],[8,10],[15,18]]` | Merge overlapping [1,3] and [2,6] |
| `[[1,4],[4,5]]` | `[[1,5]]` | Merge adjacent intervals |
| `[[1,4],[0,4]]` | `[[0,4]]` | Merge overlapping intervals |
| `[[1,4],[2,3]]` | `[[1,4]]` | One interval completely contains another |
| `[[1,2],[3,4],[5,6]]` | `[[1,2],[3,4],[5,6]]` | No overlaps, no merging needed |
| `[[1,10],[2,3],[4,5],[6,7],[8,9]]` | `[[1,10]]` | All intervals overlap with [1,10] | 