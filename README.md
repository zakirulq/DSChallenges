# Data Structures and Algorithms Challenges

A comprehensive collection of algorithm solutions and patterns implemented in C#. This repository contains solutions to common coding interview problems organized by algorithmic patterns and techniques.

## 🚀 Project Overview

This project contains implementations of various algorithmic patterns and data structure problems commonly encountered in technical interviews and competitive programming.

## 📁 Project Structure

```
AlgorithmPractice/
├── README.md                           # Main project documentation
├── Program.cs                          # Main entry point with test runners
├── *.csproj                           # C# project files
├── *.sln                              # Solution file
│
├── GraphProblems/                      # Graph and Tree-based algorithms
│   ├── MeetingRooms_README.md
│   ├── MeetingRoomsSolution.cs
│   ├── MeetingRoomsTest.cs
│   ├── CourseSchedule_README.md
│   ├── CourseScheduleSolution.cs
│   └── CourseScheduleTest.cs
│
├── TwoPointers/                        # Two Pointers and Fast/Slow Pointer patterns
│   ├── TwoSum_README.md
│   ├── TwoSumSolution.cs
│   ├── TwoSumTest.cs
│   ├── FastSlowPointer_README.md
│   ├── FastSlowPointerSolution.cs
│   └── FastSlowPointerTest.cs
│
├── MergeOperations/                     # Merge-based algorithms
│   ├── MergeIntervals_README.md
│   ├── MergeIntervalSolution.cs
│   ├── MergeIntervalTest.cs
│   ├── MergeKSortedLists_README.md
│   ├── MergeKSortedListsSolution.cs
│   └── MergeKSortedListsTest.cs
│
├── Sorting/                            # Sorting algorithms and patterns
│   ├── MergeSort_README.md
│   ├── MergeSortSolution.cs
│   ├── MergeSortTest.cs
│   ├── SortingPatterns_README.md
│   ├── SortingPatternsSolution.cs
│   └── SortingPatternsTest.cs
│
├── BinarySearch/                        # Binary Search and variants
│   ├── BinarySearch_README.md
│   ├── BinarySearchSolution.cs
│   ├── BinarySearchTest.cs
│   ├── TopKFrequent_README.md
│   ├── TopKFrequentSolution.cs
│   └── TopKFrequentTest.cs
│
├── SlidingWindow/                       # Sliding Window problems
│   ├── SlidingWindow_README.md
│   ├── SlidingWindowSolution.cs
│   └── SlidingWindowTest.cs
│
├── PrefixSum/                           # Prefix Sum and range queries
│   ├── PrefixSum_README.md
│   ├── PrefixSumSolution.cs
│   └── PrefixSumTest.cs
│
└── Greedy/                             # Greedy algorithms
    ├── Greedy_README.md
    ├── GreedySolution.cs
    └── GreedyTest.cs
```

## 🧮 Algorithm Patterns by Directory

### 📂 **GraphProblems/**
- **Meeting Rooms** - Interval scheduling and room allocation
- **Course Schedule** - Topological sorting for course prerequisites

### 📂 **TwoPointers/**
- **Two Sum** - Find pairs that sum to target
- **Fast & Slow Pointers** - Cycle detection, middle element finding, happy numbers

### 📂 **MergeOperations/**
- **Merge Intervals** - Overlapping interval merging
- **Merge K Sorted Lists** - Multiple approaches for merging sorted linked lists

### 📂 **Sorting/**
- **Merge Sort** - Divide and conquer sorting algorithm
- **Sorting Patterns** - Multiple sorting algorithms (Bubble, Selection, Insertion, Quick, Heap, Counting, Radix, Bucket) and sorting-based problems

### 📂 **BinarySearch/**
- **Binary Search** - Standard and variants (first/last occurrence, ceiling/floor, rotated array, 2D matrix search)
- **Top K Frequent Elements** - Heap-based solutions for frequent elements

### 📂 **SlidingWindow/**
- **Fixed Size Window** - Maximum sum subarray of size K
- **Variable Size Window** - Longest subarray with sum constraints
- **String Problems** - Longest substring without repeats, minimum window substring, anagrams

### 📂 **PrefixSum/**
- **Range Queries** - Efficient range sum calculations
- **Subarray Problems** - Subarray sum equals K, maximum subarray sum
- **Multiple Subarrays** - Non-overlapping subarray combinations

### 📂 **Greedy/**
- **Activity Selection** - Optimal activity scheduling
- **Jump Game** - Can reach end, minimum jumps
- **Gas Station** - Circular tour problem
- **Interval Problems** - Balloon bursting, non-overlapping intervals
- **Other Greedy** - Task scheduler, coin change, fractional knapsack, Huffman coding

## 🛠️ Technologies Used

- **Language:** C# (.NET 8.0)
- **IDE:** JetBrains Rider / Visual Studio
- **Testing:** Built-in C# testing framework
- **Documentation:** Markdown with detailed problem statements

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Any C# IDE (Visual Studio, Rider, VS Code)

### Running the Project
```bash
# Navigate to the project directory
cd AlgorithmPractice

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run all tests
dotnet run
```

## 📚 Learning Resources

Each algorithm pattern includes:
- **Problem Statement** - Exact problem as it appears in coding tests
- **Examples** - Multiple test cases with inputs and expected outputs
- **Approach** - Step-by-step solution methodology
- **Time Complexity** - Big O notation analysis
- **Test Cases** - Comprehensive test scenarios

## 🎯 Problem Categories by Difficulty

### Easy Level
- **TwoPointers/TwoSum** - Basic hash map approach
- **BinarySearch/BinarySearch** - Standard binary search
- **Sorting/SortingPatterns** - Basic sorting algorithms

### Medium Level
- **GraphProblems/MeetingRooms** - Interval scheduling
- **MergeOperations/MergeIntervals** - Interval merging
- **BinarySearch/TopKFrequent** - Heap-based solutions
- **SlidingWindow/** - Window-based problems
- **GraphProblems/CourseSchedule** - Topological sorting

### Hard Level
- **MergeOperations/MergeKSortedLists** - Multiple merge approaches
- **Greedy/** - Complex greedy algorithms
- **BinarySearch/** - Advanced binary search variants
- **Sorting/SortingPatterns** - Complex sorting-based problems

## 📖 Documentation

Each solution includes detailed README files with:
- Problem statements as they appear in coding interviews
- Multiple examples with inputs and outputs
- Algorithm approaches and time complexity analysis
- Comprehensive test cases

## 🤝 Contributing

Feel free to contribute by:
- Adding new algorithm patterns
- Improving existing solutions
- Adding more test cases
- Enhancing documentation

## 📄 License

This project is open source and available under the MIT License.

## 🎓 Learning Path

1. Start with **TwoPointers/TwoSum** and **BinarySearch/BinarySearch**
2. Move to **Sorting/SortingPatterns** and **SlidingWindow/**
3. Practice **GraphProblems/** like **CourseSchedule**
4. Advance to **Greedy/** algorithms
5. Master **MergeOperations/MergeKSortedLists**

## 🔗 Related Resources

- [LeetCode](https://leetcode.com/) - Practice problems
- [HackerRank](https://www.hackerrank.com/) - Algorithm challenges
- [GeeksforGeeks](https://www.geeksforgeeks.org/) - Algorithm tutorials

---

**Happy Coding! 🚀** 