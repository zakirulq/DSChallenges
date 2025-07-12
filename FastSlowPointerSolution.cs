using System;
using System.Collections.Generic;

// Node class for linked list
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class FastSlowPointerSolution
{
    // Problem 1: Detect Cycle in Linked List
    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null)
            return false;
        
        ListNode slow = head;
        ListNode fast = head;
        
        // Fast pointer moves 2 steps, slow pointer moves 1 step
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            // If they meet, there's a cycle
            if (slow == fast)
                return true;
        }
        
        return false;
    }
    
    // Problem 2: Find the middle node of a linked list
    public ListNode FindMiddle(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        
        ListNode slow = head;
        ListNode fast = head;
        
        // Fast pointer moves 2 steps, slow pointer moves 1 step
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return slow;
    }
    
    // Problem 3: Find the node where cycle begins (if cycle exists)
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null)
            return null;
        
        ListNode slow = head;
        ListNode fast = head;
        
        // First phase: Find meeting point
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast)
                break;
        }
        
        // If no cycle found
        if (fast == null || fast.next == null)
            return null;
        
        // Second phase: Find cycle start
        slow = head;
        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        
        return slow;
    }
    
    // Problem 4: Check if a number is happy (sum of squares of digits eventually becomes 1)
    public bool IsHappy(int n)
    {
        int slow = n;
        int fast = GetNext(n);
        
        while (fast != 1 && slow != fast)
        {
            slow = GetNext(slow);
            fast = GetNext(GetNext(fast));
        }
        
        return fast == 1;
    }
    
    private int GetNext(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
    
    // Utility methods for creating linked lists
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
    
    public ListNode CreateLinkedListWithCycle(int[] values, int cycleStartIndex)
    {
        if (values == null || values.Length == 0)
            return null;
        
        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        ListNode cycleStart = null;
        
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
            
            if (i == cycleStartIndex)
                cycleStart = current;
        }
        
        // Create cycle
        if (cycleStart != null)
            current.next = cycleStart;
        
        return head;
    }
    
    public void PrintLinkedList(ListNode head)
    {
        ListNode current = head;
        HashSet<ListNode> visited = new HashSet<ListNode>();
        int count = 0;
        
        Console.Write("[");
        while (current != null && count < 20) // Limit to prevent infinite loop
        {
            Console.Write(current.val);
            if (current.next != null)
                Console.Write(" -> ");
            
            if (visited.Contains(current))
            {
                Console.Write("(cycle detected)");
                break;
            }
            
            visited.Add(current);
            current = current.next;
            count++;
        }
        Console.WriteLine("]");
    }
} 