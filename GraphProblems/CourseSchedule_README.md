# Course Schedule II

## Problem Statement

There are a total of `numCourses` courses you have to take, labeled from `0` to `numCourses - 1`. You are given an array `prerequisites` where `prerequisites[i] = [ai, bi]` indicates that you must take course `bi` first if you want to take course `ai`.

Return the ordering of courses you should take to finish all courses. If there are many valid answers, return any of them. If it is impossible to finish all courses, return an empty array.

## Examples

### Example 1:
**Input:** `numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]`  
**Output:** `[0,1,2,3]` or `[0,2,1,3]`  
**Explanation:** One valid course order is [0,1,2,3]. Another valid course order is [0,2,1,3].

### Example 2:
**Input:** `numCourses = 2, prerequisites = [[1,0]]`  
**Output:** `[0,1]`  
**Explanation:** There are a total of 2 courses to take. To take course 1 you should have finished course 0. So the correct course order is [0,1].

### Example 3:
**Input:** `numCourses = 2, prerequisites = [[1,0],[0,1]]`  
**Output:** `[]`  
**Explanation:** It is impossible to finish all courses.

## Constraints
- `1 <= numCourses <= 2000`
- `0 <= prerequisites.length <= numCourses * (numCourses - 1)`
- `prerequisites[i].length == 2`
- `0 <= ai, bi < numCourses`
- `ai != bi`
- All the pairs `[ai, bi]` are unique.

## Approach
1. Build a directed graph from prerequisites
2. Use Topological Sort (DFS or BFS) to find valid ordering
3. Detect cycles - if cycle exists, return empty array
4. Return topological order if no cycles

## Time Complexity
- **Time:** O(V + E) where V = numCourses, E = prerequisites.length
- **Space:** O(V + E) for graph representation

## Test Cases

| Input | Expected Output | Explanation |
|-------|----------------|-------------|
| `numCourses=4, prerequisites=[[1,0],[2,0],[3,1],[3,2]]` | `[0,1,2,3]` or `[0,2,1,3]` | Valid topological order |
| `numCourses=2, prerequisites=[[1,0]]` | `[0,1]` | Simple dependency |
| `numCourses=2, prerequisites=[[1,0],[0,1]]` | `[]` | Cyclic dependency |
| `numCourses=1, prerequisites=[]` | `[0]` | Single course, no prerequisites |
| `numCourses=3, prerequisites=[[1,0],[2,1]]` | `[0,1,2]` | Linear dependency chain | 