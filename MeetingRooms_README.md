# Meeting Rooms II

## Problem Statement

Given an array of meeting time intervals `intervals` where `intervals[i] = [starti, endi]`, return the minimum number of conference rooms required.

## Examples

### Example 1:
**Input:** `intervals = [[0,30],[5,10],[15,20]]`  
**Output:** `2`  
**Explanation:** We need two conference rooms:
- Room 1: [0,30]
- Room 2: [5,10], [15,20]

### Example 2:
**Input:** `intervals = [[7,10],[2,4]]`  
**Output:** `1`  
**Explanation:** We only need one conference room since the meetings don't overlap.

## Constraints
- `1 <= intervals.length <= 104`
- `0 <= starti < endi <= 106`

## Approach
1. Sort the intervals by start time
2. Use a min-heap to track the end times of ongoing meetings
3. For each interval, check if the earliest ending meeting has finished
4. If yes, reuse that room; if no, allocate a new room

## Time Complexity
- **Time:** O(n log n) - sorting + heap operations
- **Space:** O(n) - heap storage

## Test Cases

| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `[[0,30],[5,10],[15,20]]` | `2` | Two rooms needed for overlapping meetings |
| `[[7,10],[2,4]]` | `1` | One room sufficient, no overlap |
| `[[1,5],[2,6],[3,7]]` | `3` | All meetings overlap, need 3 rooms |
| `[[1,10],[2,7],[3,19],[8,12],[10,20],[11,30]]` | `4` | Complex overlapping scenario |
| `[[1,2],[2,3],[3,4]]` | `1` | No overlap, one room sufficient | 