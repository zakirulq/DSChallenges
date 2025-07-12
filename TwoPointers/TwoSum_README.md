# Two Sum

## Problem Statement

Given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to `target`.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

## Examples

### Example 1:
**Input:** `nums = [2,7,11,15], target = 9`  
**Output:** `[0,1]`  
**Explanation:** Because `nums[0] + nums[1] == 9`, we return `[0, 1]`.

### Example 2:
**Input:** `nums = [3,2,4], target = 6`  
**Output:** `[1,2]`  
**Explanation:** Because `nums[1] + nums[2] == 6`, we return `[1, 2]`.

### Example 3:
**Input:** `nums = [3,3], target = 6`  
**Output:** `[0,1]`  
**Explanation:** Because `nums[0] + nums[1] == 6`, we return `[0, 1]`.

## Constraints
- `2 <= nums.length <= 104`
- `-109 <= nums[i] <= 109`
- `-109 <= target <= 109`
- Only one valid answer exists.

## Approach
1. **Hash Map Approach (Recommended):**
   - Use a hash map to store complements
   - For each number, check if its complement exists
   - Time: O(n), Space: O(n)

2. **Two Pointers Approach (if array is sorted):**
   - Sort the array first
   - Use two pointers from start and end
   - Time: O(n log n), Space: O(1)

3. **Brute Force:**
   - Check all pairs
   - Time: O(n²), Space: O(1)

## Time Complexity
- **Hash Map:** O(n) time, O(n) space
- **Two Pointers:** O(n log n) time, O(1) space
- **Brute Force:** O(n²) time, O(1) space

## Test Cases

| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[2,7,11,15], target=9` | `[0,1]` | 2 + 7 = 9 |
| `nums=[3,2,4], target=6` | `[1,2]` | 2 + 4 = 6 |
| `nums=[3,3], target=6` | `[0,1]` | 3 + 3 = 6 |
| `nums=[1,5,8,10,13], target=18` | `[2,4]` | 8 + 10 = 18 |
| `nums=[-1,-2,-3,-4,-5], target=-8` | `[2,4]` | -3 + (-5) = -8 | 