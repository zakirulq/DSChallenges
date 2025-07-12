using System;

namespace BinarySearch
{
    public class BinarySearchSolution
    {
        // Standard Binary Search
        public int BinarySearch(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            
            return -1; // Not found
        }
        
        // Find First Occurrence of target
        public int FindFirstOccurrence(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int result = -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] == target)
                {
                    result = mid;
                    right = mid - 1; // Continue searching left half
                }
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            
            return result;
        }
        
        // Find Last Occurrence of target
        public int FindLastOccurrence(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int result = -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] == target)
                {
                    result = mid;
                    left = mid + 1; // Continue searching right half
                }
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            
            return result;
        }
        
        // Find Ceiling (smallest element >= target)
        public int FindCeiling(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int result = -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] >= target)
                {
                    result = mid;
                    right = mid - 1; // Try to find smaller ceiling
                }
                else
                    left = mid + 1;
            }
            
            return result;
        }
        
        // Find Floor (largest element <= target)
        public int FindFloor(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int result = -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] <= target)
                {
                    result = mid;
                    left = mid + 1; // Try to find larger floor
                }
                else
                    right = mid - 1;
            }
            
            return result;
        }
        
        // Search in Rotated Sorted Array
        public int SearchInRotatedArray(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] == target)
                    return mid;
                
                // Check if left half is sorted
                if (nums[left] <= nums[mid])
                {
                    // Target is in left half
                    if (nums[left] <= target && target < nums[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else
                {
                    // Right half is sorted
                    if (nums[mid] < target && target <= nums[right])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }
            
            return -1;
        }
        
        // Find Minimum in Rotated Sorted Array
        public int FindMinInRotatedArray(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] > nums[right])
                    left = mid + 1;
                else
                    right = mid;
            }
            
            return nums[left];
        }
        
        // Search in 2D Matrix (sorted row-wise and column-wise)
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            int row = 0;
            int col = cols - 1;
            
            while (row < rows && col >= 0)
            {
                if (matrix[row, col] == target)
                    return true;
                else if (matrix[row, col] < target)
                    row++;
                else
                    col--;
            }
            
            return false;
        }
        
        // Find Peak Element (any peak)
        public int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] > nums[mid + 1])
                    right = mid;
                else
                    left = mid + 1;
            }
            
            return left;
        }
        
        // Binary Search on Answer (Square Root)
        public int MySqrt(int x)
        {
            if (x <= 1) return x;
            
            int left = 1;
            int right = x;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (mid <= x / mid)
                    left = mid + 1;
                else
                    right = mid;
            }
            
            return left - 1;
        }
        
        // Utility method to print array
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
        
        // Utility method to print 2D array
        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            Console.WriteLine("[");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("  [");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j < cols - 1)
                        Console.Write(", ");
                }
                Console.WriteLine("]");
            }
            Console.WriteLine("]");
        }
    }
} 