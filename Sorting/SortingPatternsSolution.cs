using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public class SortingPatternsSolution
    {
        // Bubble Sort
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }
                if (!swapped) break; // Array is sorted
            }
        }
        
        // Selection Sort
        public void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                Swap(arr, i, minIndex);
            }
        }
        
        // Insertion Sort
        public void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        
        // Quick Sort
        public void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        
        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        
        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            
            Swap(arr, i + 1, high);
            return i + 1;
        }
        
        // Heap Sort
        public void HeapSort(int[] arr)
        {
            int n = arr.Length;
            
            // Build max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);
            
            // Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                Swap(arr, 0, i);
                Heapify(arr, i, 0);
            }
        }
        
        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            
            if (left < n && arr[left] > arr[largest])
                largest = left;
            
            if (right < n && arr[right] > arr[largest])
                largest = right;
            
            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }
        
        // Counting Sort (for integers in a known range)
        public void CountingSort(int[] arr, int maxValue)
        {
            int n = arr.Length;
            int[] count = new int[maxValue + 1];
            int[] output = new int[n];
            
            // Count occurrences
            for (int i = 0; i < n; i++)
                count[arr[i]]++;
            
            // Modify count array to store actual positions
            for (int i = 1; i <= maxValue; i++)
                count[i] += count[i - 1];
            
            // Build output array
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }
            
            // Copy back to original array
            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }
        
        // Radix Sort
        public void RadixSort(int[] arr)
        {
            int max = arr.Max();
            
            for (int exp = 1; max / exp > 0; exp *= 10)
                CountSortByDigit(arr, exp);
        }
        
        private void CountSortByDigit(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];
            
            // Count occurrences
            for (int i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
            
            // Modify count array
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];
            
            // Build output array
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }
            
            // Copy back
            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }
        
        // Bucket Sort
        public void BucketSort(double[] arr)
        {
            int n = arr.Length;
            if (n <= 0) return;
            
            // Create buckets
            var buckets = new List<double>[n];
            for (int i = 0; i < n; i++)
                buckets[i] = new List<double>();
            
            // Distribute elements into buckets
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (int)(n * arr[i]);
                buckets[bucketIndex].Add(arr[i]);
            }
            
            // Sort individual buckets
            for (int i = 0; i < n; i++)
                buckets[i].Sort();
            
            // Concatenate buckets
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                foreach (double item in buckets[i])
                {
                    arr[index++] = item;
                }
            }
        }
        
        // Sorting-Based Problem Solving Patterns
        
        // 1. Two Sum (using sorting)
        public int[] TwoSumSorted(int[] nums, int target)
        {
            var indexedNums = new List<(int value, int index)>();
            for (int i = 0; i < nums.Length; i++)
            {
                indexedNums.Add((nums[i], i));
            }
            
            indexedNums.Sort((a, b) => a.value.CompareTo(b.value));
            
            int left = 0, right = indexedNums.Count - 1;
            
            while (left < right)
            {
                int sum = indexedNums[left].value + indexedNums[right].value;
                if (sum == target)
                {
                    return new int[] { indexedNums[left].index, indexedNums[right].index };
                }
                else if (sum < target)
                    left++;
                else
                    right--;
            }
            
            return new int[] { -1, -1 };
        }
        
        // 2. Three Sum
        public List<List<int>> ThreeSum(int[] nums)
        {
            var result = new List<List<int>>();
            Array.Sort(nums);
            
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicates
                
                int left = i + 1, right = nums.Length - 1;
                
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        
                        // Skip duplicates
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                        left++;
                    else
                        right--;
                }
            }
            
            return result;
        }
        
        // 3. Kth Largest Element
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
        
        // 4. Meeting Rooms (check if person can attend all meetings)
        public bool CanAttendMeetings(int[][] intervals)
        {
            if (intervals == null || intervals.Length <= 1)
                return true;
            
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < intervals[i - 1][1])
                    return false;
            }
            
            return true;
        }
        
        // 5. Merge Intervals
        public int[][] MergeIntervals(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return new int[0][];
            
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            
            var result = new List<int[]>();
            result.Add(intervals[0]);
            
            for (int i = 1; i < intervals.Length; i++)
            {
                var last = result[result.Count - 1];
                
                if (intervals[i][0] <= last[1])
                {
                    last[1] = Math.Max(last[1], intervals[i][1]);
                }
                else
                {
                    result.Add(intervals[i]);
                }
            }
            
            return result.ToArray();
        }
        
        // 6. Sort Colors (Dutch National Flag)
        public void SortColors(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    Swap(nums, low, mid);
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else // nums[mid] == 2
                {
                    Swap(nums, mid, high);
                    high--;
                }
            }
        }
        
        // 7. Valid Anagram
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            
            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();
            
            Array.Sort(sChars);
            Array.Sort(tChars);
            
            return new string(sChars) == new string(tChars);
        }
        
        // 8. H-Index
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);
            int n = citations.Length;
            
            for (int i = 0; i < n; i++)
            {
                if (citations[i] >= n - i)
                    return n - i;
            }
            
            return 0;
        }
        
        // 9. Largest Number
        public string LargestNumber(int[] nums)
        {
            var numStrings = nums.Select(x => x.ToString()).ToArray();
            
            Array.Sort(numStrings, (a, b) => (b + a).CompareTo(a + b));
            
            if (numStrings[0] == "0") return "0";
            
            return string.Join("", numStrings);
        }
        
        // 10. Custom Sort String
        public string CustomSortString(string order, string s)
        {
            var charOrder = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
            {
                charOrder[order[i]] = i;
            }
            
            var sChars = s.ToCharArray();
            Array.Sort(sChars, (a, b) => 
            {
                int orderA = charOrder.ContainsKey(a) ? charOrder[a] : int.MaxValue;
                int orderB = charOrder.ContainsKey(b) ? charOrder[b] : int.MaxValue;
                return orderA.CompareTo(orderB);
            });
            
            return new string(sChars);
        }
        
        // Utility methods
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
        public void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
        
        public void PrintArray(double[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
        
        public void Print2DArray(int[][] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{arr[i][0]}, {arr[i][1]}]");
                if (i < arr.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
} 