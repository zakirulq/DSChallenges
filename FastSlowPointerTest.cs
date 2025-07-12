using System;

public class FastSlowPointerTest
{
    public static void TestFastSlowPointer()
    {
        Console.WriteLine("--- Testing Fast and Slow Pointer Problems ---");
        FastSlowPointerSolution sol = new FastSlowPointerSolution();

        // Test 1: Cycle Detection
        Console.WriteLine("1. Testing Cycle Detection:");
        
        // No cycle
        int[] values1 = { 1, 2, 3, 4, 5 };
        ListNode list1 = sol.CreateLinkedList(values1);
        Console.Write("Linked list: ");
        sol.PrintLinkedList(list1);
        bool hasCycle1 = sol.HasCycle(list1);
        Console.WriteLine($"Has cycle: {hasCycle1}");
        // Expected: false

        // With cycle
        ListNode list2 = sol.CreateLinkedListWithCycle(values1, 2);
        Console.Write("Linked list with cycle: ");
        sol.PrintLinkedList(list2);
        bool hasCycle2 = sol.HasCycle(list2);
        Console.WriteLine($"Has cycle: {hasCycle2}");
        // Expected: true

        // Test 2: Find Middle Node
        Console.WriteLine("\n2. Testing Find Middle Node:");
        int[] values2 = { 1, 2, 3, 4, 5 };
        ListNode list3 = sol.CreateLinkedList(values2);
        Console.Write("Linked list: ");
        sol.PrintLinkedList(list3);
        ListNode middle = sol.FindMiddle(list3);
        Console.WriteLine($"Middle node value: {middle.val}");
        // Expected: 3

        int[] values3 = { 1, 2, 3, 4, 5, 6 };
        ListNode list4 = sol.CreateLinkedList(values3);
        Console.Write("Linked list: ");
        sol.PrintLinkedList(list4);
        ListNode middle2 = sol.FindMiddle(list4);
        Console.WriteLine($"Middle node value: {middle2.val}");
        // Expected: 4 (second middle for even length)

        // Test 3: Detect Cycle Start
        Console.WriteLine("\n3. Testing Detect Cycle Start:");
        ListNode list5 = sol.CreateLinkedListWithCycle(values1, 2);
        Console.Write("Linked list with cycle: ");
        sol.PrintLinkedList(list5);
        ListNode cycleStart = sol.DetectCycle(list5);
        Console.WriteLine($"Cycle starts at node with value: {cycleStart.val}");
        // Expected: 3

        // Test 4: Happy Number
        Console.WriteLine("\n4. Testing Happy Number:");
        int[] testNumbers = { 19, 2, 7, 4 };
        foreach (int num in testNumbers)
        {
            bool isHappy = sol.IsHappy(num);
            Console.WriteLine($"Is {num} a happy number? {isHappy}");
        }
        // Expected: 19=true, 2=false, 7=true, 4=false
        Console.WriteLine();
    }
} 