# Greedy Algorithms and Interval Partitioning

## Problem Statement

Greedy algorithms make locally optimal choices at each step with the hope of finding a global optimum. They are particularly useful for optimization problems where making the best choice at each step leads to the best overall solution.

## Common Greedy Problems

### 1. Activity Selection Problem
**Problem:** Given n activities with their start and finish times, select the maximum number of activities that can be performed by a single person.

**Example:**
```
Input: start = [1,3,0,5,8,5], end = [2,4,6,7,9,9]
Output: 4
Explanation: Activities [1,2], [3,4], [5,7], [8,9] can be performed.
```

### 2. Minimum Number of Arrows to Burst Balloons
**Problem:** Given points representing the width of balloons, find the minimum number of arrows needed to burst all balloons.

**Example:**
```
Input: points = [[10,16],[2,8],[1,6],[7,12]]
Output: 2
Explanation: One arrow can burst [2,8] and [1,6], another can burst [10,16] and [7,12].
```

### 3. Jump Game
**Problem:** Given an array of non-negative integers, you are initially positioned at the first index. Determine if you can reach the last index.

**Example:**
```
Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
```

### 4. Gas Station
**Problem:** Given gas and cost arrays, find the starting gas station index to complete a circular tour.

**Example:**
```
Input: gas = [1,2,3,4,5], cost = [3,4,5,1,2]
Output: 3
Explanation: Start at station 3 (index 3) and fill up with 4 unit of gas.
```

### 5. Task Scheduler
**Problem:** Given a characters array tasks representing CPU tasks, return the least number of units of times needed to finish all tasks.

**Example:**
```
Input: tasks = ['A','A','A','B','B','B'], n = 2
Output: 8
Explanation: A -> B -> idle -> A -> B -> idle -> A -> B
```

## Approach

### Greedy Strategy:
1. **Sort:** Often sort by end time, start time, or other criteria
2. **Select:** Choose the locally optimal choice
3. **Update:** Move to next decision point
4. **Repeat:** Continue until all elements processed

### Key Principles:
- **Optimal Substructure:** Optimal solution contains optimal solutions to subproblems
- **Greedy Choice Property:** Locally optimal choice leads to globally optimal solution

## Time Complexity
- **Time:** O(n log n) - often involves sorting
- **Space:** O(1) - usually constant extra space

## Test Cases

### Activity Selection:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `start=[1,3,0,5,8,5], end=[2,4,6,7,9,9]` | `4` | Maximum activities that can be performed |
| `start=[1,2,3], end=[2,3,4]` | `3` | All activities can be performed |

### Jump Game:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `nums=[2,3,1,1,4]` | `true` | Can reach the end |
| `nums=[3,2,1,0,4]` | `false` | Cannot reach the end |
| `nums=[0]` | `true` | Already at the end |

### Gas Station:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `gas=[1,2,3,4,5], cost=[3,4,5,1,2]` | `3` | Start at station 3 |
| `gas=[2,3,4], cost=[3,4,3]` | `-1` | No solution exists |

### Task Scheduler:
| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `tasks=['A','A','A','B','B','B'], n=2` | `8` | Need 8 units of time |
| `tasks=['A','A','A','B','B','B'], n=0` | `6` | No cooldown needed | 