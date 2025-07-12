using System;

namespace Sorting
{
    public class SortingPatternsTest
    {
        public static void TestSortingPatterns()
        {
            Console.WriteLine("--- Testing Sorting-Based Patterns ---");
            SortingPatternsSolution sol = new SortingPatternsSolution();

            // Test 1: Basic Sorting Algorithms
            Console.WriteLine("1. Testing Basic Sorting Algorithms:");
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.Write("Original array: ");
            sol.PrintArray(arr1);
            
            int[] arr1Copy = (int[])arr1.Clone();
            sol.BubbleSort(arr1Copy);
            Console.Write("After Bubble Sort: ");
            sol.PrintArray(arr1Copy);
            // Expected: [11, 12, 22, 25, 34, 64, 90]

            // Test 2: Selection Sort
            Console.WriteLine("\n2. Testing Selection Sort:");
            int[] arr2 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.Write("Original array: ");
            sol.PrintArray(arr2);
            
            sol.SelectionSort(arr2);
            Console.Write("After Selection Sort: ");
            sol.PrintArray(arr2);
            // Expected: [11, 12, 22, 25, 34, 64, 90]

            // Test 3: Insertion Sort
            Console.WriteLine("\n3. Testing Insertion Sort:");
            int[] arr3 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.Write("Original array: ");
            sol.PrintArray(arr3);
            
            sol.InsertionSort(arr3);
            Console.Write("After Insertion Sort: ");
            sol.PrintArray(arr3);
            // Expected: [11, 12, 22, 25, 34, 64, 90]

            // Test 4: Quick Sort
            Console.WriteLine("\n4. Testing Quick Sort:");
            int[] arr4 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.Write("Original array: ");
            sol.PrintArray(arr4);
            
            sol.QuickSort(arr4);
            Console.Write("After Quick Sort: ");
            sol.PrintArray(arr4);
            // Expected: [11, 12, 22, 25, 34, 64, 90]

            // Test 5: Heap Sort
            Console.WriteLine("\n5. Testing Heap Sort:");
            int[] arr5 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.Write("Original array: ");
            sol.PrintArray(arr5);
            
            sol.HeapSort(arr5);
            Console.Write("After Heap Sort: ");
            sol.PrintArray(arr5);
            // Expected: [11, 12, 22, 25, 34, 64, 90]

            // Test 6: Counting Sort
            Console.WriteLine("\n6. Testing Counting Sort:");
            int[] arr6 = { 4, 2, 1, 4, 1, 4, 2, 1 };
            Console.Write("Original array: ");
            sol.PrintArray(arr6);
            
            sol.CountingSort(arr6, 4);
            Console.Write("After Counting Sort: ");
            sol.PrintArray(arr6);
            // Expected: [1, 1, 1, 2, 2, 4, 4, 4]

            // Test 7: Radix Sort
            Console.WriteLine("\n7. Testing Radix Sort:");
            int[] arr7 = { 170, 45, 75, 90, 802, 24, 2, 66 };
            Console.Write("Original array: ");
            sol.PrintArray(arr7);
            
            sol.RadixSort(arr7);
            Console.Write("After Radix Sort: ");
            sol.PrintArray(arr7);
            // Expected: [2, 24, 45, 66, 75, 90, 170, 802]

            // Test 8: Bucket Sort
            Console.WriteLine("\n8. Testing Bucket Sort:");
            double[] arr8 = { 0.897, 0.565, 0.656, 0.1234, 0.665, 0.3434 };
            Console.Write("Original array: ");
            sol.PrintArray(arr8);
            
            sol.BucketSort(arr8);
            Console.Write("After Bucket Sort: ");
            sol.PrintArray(arr8);
            // Expected: [0.1234, 0.3434, 0.565, 0.656, 0.665, 0.897]

            // Test 9: Two Sum using sorting
            Console.WriteLine("\n9. Testing Two Sum using Sorting:");
            int[] nums9 = { 2, 7, 11, 15 };
            int target9 = 9;
            Console.Write("Array: ");
            sol.PrintArray(nums9);
            Console.WriteLine($"Target: {target9}");
            
            int[] result9 = sol.TwoSumSorted(nums9, target9);
            Console.Write("Indices: ");
            sol.PrintArray(result9);
            // Expected: [0, 1]

            // Test 10: Three Sum
            Console.WriteLine("\n10. Testing Three Sum:");
            int[] nums10 = { -1, 0, 1, 2, -1, -4 };
            Console.Write("Array: ");
            sol.PrintArray(nums10);
            
            var result10 = sol.ThreeSum(nums10);
            Console.WriteLine("Triplets:");
            foreach (var triplet in result10)
            {
                Console.WriteLine($"  [{string.Join(", ", triplet)}]");
            }
            // Expected: [[-1,-1,2], [-1,0,1]]

            // Test 11: Kth Largest Element
            Console.WriteLine("\n11. Testing Kth Largest Element:");
            int[] nums11 = { 3, 2, 1, 5, 6, 4 };
            int k11 = 2;
            Console.Write("Array: ");
            sol.PrintArray(nums11);
            Console.WriteLine($"k = {k11}");
            
            int kthLargest = sol.FindKthLargest(nums11, k11);
            Console.WriteLine($"Kth largest element: {kthLargest}");
            // Expected: 5

            // Test 12: Meeting Rooms
            Console.WriteLine("\n12. Testing Meeting Rooms:");
            int[][] intervals12 = {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 }
            };
            Console.Write("Intervals: ");
            sol.Print2DArray(intervals12);
            
            bool canAttend = sol.CanAttendMeetings(intervals12);
            Console.WriteLine($"Can attend all meetings: {canAttend}");
            // Expected: false

            // Test 13: Merge Intervals
            Console.WriteLine("\n13. Testing Merge Intervals:");
            int[][] intervals13 = {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            };
            Console.Write("Intervals: ");
            sol.Print2DArray(intervals13);
            
            var mergedIntervals = sol.MergeIntervals(intervals13);
            Console.Write("Merged intervals: ");
            sol.Print2DArray(mergedIntervals);
            // Expected: [[1, 6], [8, 10], [15, 18]]

            // Test 14: Sort Colors (Dutch National Flag)
            Console.WriteLine("\n14. Testing Sort Colors:");
            int[] colors = { 2, 0, 2, 1, 1, 0 };
            Console.Write("Original colors: ");
            sol.PrintArray(colors);
            
            sol.SortColors(colors);
            Console.Write("After sorting: ");
            sol.PrintArray(colors);
            // Expected: [0, 0, 1, 1, 2, 2]

            // Test 15: Valid Anagram
            Console.WriteLine("\n15. Testing Valid Anagram:");
            string s15 = "anagram";
            string t15 = "nagaram";
            Console.WriteLine($"s = \"{s15}\", t = \"{t15}\"");
            
            bool isAnagram = sol.IsAnagram(s15, t15);
            Console.WriteLine($"Is anagram: {isAnagram}");
            // Expected: true

            // Test 16: H-Index
            Console.WriteLine("\n16. Testing H-Index:");
            int[] citations = { 3, 0, 6, 1, 5 };
            Console.Write("Citations: ");
            sol.PrintArray(citations);
            
            int hIndex = sol.HIndex(citations);
            Console.WriteLine($"H-Index: {hIndex}");
            // Expected: 3

            // Test 17: Largest Number
            Console.WriteLine("\n17. Testing Largest Number:");
            int[] nums17 = { 10, 2 };
            Console.Write("Numbers: ");
            sol.PrintArray(nums17);
            
            string largestNum = sol.LargestNumber(nums17);
            Console.WriteLine($"Largest number: {largestNum}");
            // Expected: "210"

            // Test 18: Custom Sort String
            Console.WriteLine("\n18. Testing Custom Sort String:");
            string order18 = "cba";
            string s18 = "abcd";
            Console.WriteLine($"order = \"{order18}\", s = \"{s18}\"");
            
            string customSorted = sol.CustomSortString(order18, s18);
            Console.WriteLine($"Custom sorted: \"{customSorted}\"");
            // Expected: "cbad"
            Console.WriteLine();
        }
    }
} 