using System;
using System.Collections.Generic;

public class MergeKSortedListsSolution
{
    // Approach 1: Divide and Conquer (Most Efficient)
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;
        
        return MergeKListsDivideAndConquer(lists, 0, lists.Length - 1);
    }
    
    private ListNode MergeKListsDivideAndConquer(ListNode[] lists, int start, int end)
    {
        if (start == end)
            return lists[start];
        
        if (start > end)
            return null;
        
        int mid = start + (end - start) / 2;
        ListNode left = MergeKListsDivideAndConquer(lists, start, mid);
        ListNode right = MergeKListsDivideAndConquer(lists, mid + 1, end);
        
        return MergeTwoLists(left, right);
    }
    
    private ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }
        
        current.next = l1 ?? l2;
        return dummy.next;
    }
    
    // Approach 2: Priority Queue (Min Heap)
    public ListNode MergeKListsPriorityQueue(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;
        
        var minHeap = new SortedSet<(int val, int index, ListNode node)>(
            Comparer<(int val, int index, ListNode node)>.Create((a, b) => 
            {
                if (a.val != b.val)
                    return a.val.CompareTo(b.val);
                return a.index.CompareTo(b.index);
            }));
        
        // Add first node from each list
        for (int i = 0; i < lists.Length; i++)
        {
            if (lists[i] != null)
            {
                minHeap.Add((lists[i].val, i, lists[i]));
            }
        }
        
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while (minHeap.Count > 0)
        {
            var (val, index, node) = minHeap.Min;
            minHeap.Remove(minHeap.Min);
            
            current.next = node;
            current = current.next;
            
            // Add next node from the same list
            if (node.next != null)
            {
                minHeap.Add((node.next.val, index, node.next));
            }
        }
        
        return dummy.next;
    }
    
    // Approach 3: Brute Force - Collect all values and sort
    public ListNode MergeKListsBruteForce(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;
        
        var values = new List<int>();
        
        // Collect all values
        foreach (var list in lists)
        {
            ListNode current = list;
            while (current != null)
            {
                values.Add(current.val);
                current = current.next;
            }
        }
        
        // Sort values
        values.Sort();
        
        // Create new linked list
        ListNode dummy = new ListNode(0);
        ListNode currentResult = dummy;
        
        foreach (int val in values)
        {
            currentResult.next = new ListNode(val);
            currentResult = currentResult.next;
        }
        
        return dummy.next;
    }
    
    // Approach 4: Merge one by one
    public ListNode MergeKListsOneByOne(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;
        
        ListNode result = lists[0];
        
        for (int i = 1; i < lists.Length; i++)
        {
            result = MergeTwoLists(result, lists[i]);
        }
        
        return result;
    }
    
    // Approach 5: Using LINQ (for demonstration)
    public ListNode MergeKListsLinq(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;
        
        var allValues = new List<int>();
        
        foreach (var list in lists)
        {
            ListNode current = list;
            while (current != null)
            {
                allValues.Add(current.val);
                current = current.next;
            }
        }
        
        var sortedValues = allValues.OrderBy(x => x).ToList();
        
        ListNode dummy = new ListNode(0);
        ListNode currentLinq = dummy;
        
        foreach (int val in sortedValues)
        {
            currentLinq.next = new ListNode(val);
            currentLinq = currentLinq.next;
        }
        
        return dummy.next;
    }
    
    // Utility methods for creating and printing linked lists
    public ListNode CreateLinkedList(int[] values)
    {
        if (values == null || values.Length == 0)
            return null;
        
        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        
        return head;
    }
    
    public void PrintLinkedList(ListNode head)
    {
        ListNode current = head;
        Console.Write("[");
        while (current != null)
        {
            Console.Write(current.val);
            if (current.next != null)
                Console.Write(" -> ");
            current = current.next;
        }
        Console.WriteLine("]");
    }
    
    public void PrintLinkedListArray(ListNode[] lists)
    {
        Console.WriteLine("Input Lists:");
        for (int i = 0; i < lists.Length; i++)
        {
            Console.Write($"List {i}: ");
            PrintLinkedList(lists[i]);
        }
    }
    
    // Helper method to compare two linked lists
    public bool AreListsEqual(ListNode l1, ListNode l2)
    {
        while (l1 != null && l2 != null)
        {
            if (l1.val != l2.val)
                return false;
            l1 = l1.next;
            l2 = l2.next;
        }
        
        return l1 == null && l2 == null;
    }
    
    // Helper method to get list length
    public int GetListLength(ListNode head)
    {
        int count = 0;
        ListNode current = head;
        while (current != null)
        {
            count++;
            current = current.next;
        }
        return count;
    }
    
    // Helper method to convert linked list to array
    public int[] LinkedListToArray(ListNode head)
    {
        var values = new List<int>();
        ListNode current = head;
        
        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }
        
        return values.ToArray();
    }
} 