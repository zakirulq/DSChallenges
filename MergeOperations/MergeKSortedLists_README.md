# Merge K Sorted Lists

## Problem Statement

You are given an array of `k` linked-lists `lists`, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.

## Examples

### Example 1:
**Input:** `lists = [[1,4,5],[1,3,4],[2,6]]`  
**Output:** `[1,1,2,3,4,4,5,6]`  
**Explanation:** Merging the three sorted lists:
- List 1: [1,4,5]
- List 2: [1,3,4]  
- List 3: [2,6]
- Result: [1,1,2,3,4,4,5,6]

### Example 2:
**Input:** `lists = []`  
**Output:** `[]`  
**Explanation:** No lists to merge.

### Example 3:
**Input:** `lists = [[]]`  
**Output:** `[]`  
**Explanation:** Empty list.

## Constraints
- `k == lists.length`
- `0 <= k <= 104`
- `0 <= lists[i].length <= 500`
- `-104 <= lists[i][j] <= 104`
- `lists[i]` is sorted in ascending order
- The sum of `lists[i].length` will not exceed `104`

## Approaches

### 1. Divide and Conquer (Recommended)
1. **Divide:** Split lists into pairs
2. **Conquer:** Merge pairs recursively
3. **Combine:** Merge two sorted lists
4. **Time:** O(N log k), **Space:** O(log k)

### 2. Priority Queue (Min-Heap)
1. **Initialize:** Add first node of each list to heap
2. **Extract:** Remove minimum node from heap
3. **Add:** Add next node from same list to heap
4. **Time:** O(N log k), **Space:** O(k)

### 3. Brute Force
1. **Collect:** Gather all nodes into array
2. **Sort:** Sort the array
3. **Build:** Create new linked list
4. **Time:** O(N log N), **Space:** O(N)

### 4. Merge One by One
1. **Initialize:** Start with first list
2. **Iterate:** Merge each subsequent list
3. **Time:** O(kN), **Space:** O(1)

## Time Complexity
- **Divide and Conquer:** O(N log k) time, O(log k) space
- **Priority Queue:** O(N log k) time, O(k) space
- **Brute Force:** O(N log N) time, O(N) space
- **One by One:** O(kN) time, O(1) space

Where N = total number of nodes across all lists.

## Test Cases

| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `[[1,4,5],[1,3,4],[2,6]]` | `[1,1,2,3,4,4,5,6]` | Merge three sorted lists |
| `[]` | `[]` | Empty input |
| `[[]]` | `[]` | Single empty list |
| `[[1,2,3],[4,5,6],[7,8,9]]` | `[1,2,3,4,5,6,7,8,9]` | Three non-overlapping lists |
| `[[1,1,1],[2,2,2],[3,3,3]]` | `[1,1,1,2,2,2,3,3,3]` | Lists with duplicates |
| `[[1],[2],[3],[4],[5]]` | `[1,2,3,4,5]` | Single element lists | 