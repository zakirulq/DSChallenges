using System;

public class MergeSortSolution
{
    public void MergeSort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;
        
        MergeSort(arr, 0, arr.Length - 1);
    }
    
    private void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            
            // Divide: Recursively sort the two halves
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            
            // Conquer: Merge the sorted halves
            Merge(arr, left, mid, right);
        }
    }
    
    private void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        
        // Create temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];
        
        // Copy data to temporary arrays
        for (int i = 0; i < n1; i++)
            leftArray[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = arr[mid + 1 + j];
        
        // Merge the temporary arrays back into arr[left..right]
        int i_left = 0, i_right = 0, k = left;
        
        while (i_left < n1 && i_right < n2)
        {
            if (leftArray[i_left] <= rightArray[i_right])
            {
                arr[k] = leftArray[i_left];
                i_left++;
            }
            else
            {
                arr[k] = rightArray[i_right];
                i_right++;
            }
            k++;
        }
        
        // Copy remaining elements of leftArray[], if any
        while (i_left < n1)
        {
            arr[k] = leftArray[i_left];
            i_left++;
            k++;
        }
        
        // Copy remaining elements of rightArray[], if any
        while (i_right < n2)
        {
            arr[k] = rightArray[i_right];
            i_right++;
            k++;
        }
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
} 