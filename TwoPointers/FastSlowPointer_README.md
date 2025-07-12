# Fast and Slow Pointer Problems

## Problem Statement

The Fast and Slow Pointer technique (also known as Floyd's Cycle Detection Algorithm) is used to solve problems involving linked lists, arrays, and other data structures where we need to detect cycles, find middle elements, or solve similar problems efficiently.

## Common Problems Solved

### 1. Linked List Cycle Detection

**Problem:** Given the head of a linked list, determine if the linked list has a cycle in it.

**Example:**
```
Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
```

### 2. Find Middle Node

**Problem:** Given the head of a singly linked list, return the middle node of the linked list.

**Example:**
```
Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
```

### 3. Happy Number

**Problem:** Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:
- Starting with any positive integer, replace the number by the sum of the squares of its digits.
- Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.

**Example:**
```
Input: n = 19
Output: true
Explanation: 
1² + 9² = 82
8² + 2² = 68
6² + 8² = 100
1² + 0² + 0² = 1
```

## Approach

### Fast and Slow Pointer Technique:
1. **Two Pointers:** Use two pointers moving at different speeds
2. **Fast Pointer:** Moves twice as fast as slow pointer
3. **Cycle Detection:** If there's a cycle, fast and slow will meet
4. **Middle Finding:** When fast reaches end, slow is at middle

## Time Complexity
- **Time:** O(n) - linear time complexity
- **Space:** O(1) - constant extra space

## Test Cases

### Cycle Detection:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `[1,2,3,4,5]` (no cycle) | `false` | No cycle in list |
| `[1,2,3,4,5]` (cycle at node 3) | `true` | Cycle exists |
| `[1]` (no cycle) | `false` | Single node, no cycle |

### Find Middle:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `[1,2,3,4,5]` | `3` | Middle of odd-length list |
| `[1,2,3,4,5,6]` | `4` | Second middle of even-length list |
| `[1,2]` | `2` | Middle of 2-element list |

### Happy Number:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `19` | `true` | Happy number (ends at 1) |
| `2` | `false` | Not happy (enters cycle) |
| `7` | `true` | Happy number |
| `4` | `false` | Not happy number | 