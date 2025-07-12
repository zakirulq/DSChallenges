# Top K Frequent Elements

## Problem Statement

Given an integer array `nums` and an integer `k`, return the `k` most frequent elements. You may return the answer in any order.

## Examples

### Example 1:
**Input:** `nums = [1,1,1,2,2,3], k = 2`  
**Output:** `[1,2]`  
**Explanation:** Element 1 appears 3 times, element 2 appears 2 times. The two most frequent elements are 1 and 2.

### Example 2:
**Input:** `nums = [1], k = 1`  
**Output:** `[1]`  
**Explanation:** The only element in the array is 1, so it's the most frequent.

### Example 3:
**Input:** `nums = [1,2,3,4,5], k = 3`  
**Output:** `[1,2,3]` or `[1,3,2]` or `[2,1,3]` etc.  
**Explanation:** All elements appear once, so any 3 elements can be returned.

## Constraints
- `1 <= nums.length <= 105`
- `-104 <= nums[i] <= 104`
- `k` is in the range `[1, the number of unique elements in the array]`
- It is guaranteed that the answer is unique.

## Approaches

### 1. Heap Approach (Recommended)
1. Count frequency of each element using HashMap
2. Use Min-Heap to keep top K frequent elements
3. Time: O(n log k), Space: O(n)

### 2. Bucket Sort
1. Count frequency of each element
2. Create buckets based on frequency
3. Time: O(n), Space: O(n)

### 3. Quick Select
1. Count frequency of each element
2. Use Quick Select to find Kth most frequent
3. Time: O(n) average, Space: O(n)

### 4. LINQ Approach
1. Use LINQ GroupBy and OrderByDescending
2. Time: O(n log n), Space: O(n)

## Time Complexity
- **Heap:** O(n log k) time, O(n) space
- **Bucket Sort:** O(n) time, O(n) space
- **Quick Select:** O(n) average time, O(n) space
- **LINQ:** O(n log n) time, O(n) space

## Test Cases

| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[1,1,1,2,2,3], k=2` | `[1,2]` | 1 appears 3 times, 2 appears 2 times |
| `nums=[1], k=1` | `[1]` | Single element |
| `nums=[1,2,3,4,5], k=3` | `[1,2,3]` | All elements have same frequency |
| `nums=[1,1,1,2,2,2,3,3,4,5,6,7,8,9], k=3` | `[1,2,3]` | All have frequency 3 |
| `nums=[1,1,1,2,2,3], k=1` | `[1]` | Only the most frequent element | 