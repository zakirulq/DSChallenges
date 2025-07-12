using System;

namespace MergeOperations
{
    public class MergeKSortedListsTest
    {
        public static void TestMergeKSortedLists()
        {
            Console.WriteLine("--- Testing Merge K Sorted Lists ---");
            MergeKSortedListsSolution sol = new MergeKSortedListsSolution();

            // Test 1: Basic case with 3 lists
            Console.WriteLine("1. Testing Basic Case with 3 Lists:");
            int[] list1Values = { 1, 4, 5 };
            int[] list2Values = { 1, 3, 4 };
            int[] list3Values = { 2, 6 };
            
            ListNode list1 = sol.CreateLinkedList(list1Values);
            ListNode list2 = sol.CreateLinkedList(list2Values);
            ListNode list3 = sol.CreateLinkedList(list3Values);
            
            ListNode[] lists1 = { list1, list2, list3 };
            
            Console.WriteLine("Input Lists:");
            sol.PrintLinkedListArray(lists1);
            
            ListNode result1 = sol.MergeKLists(lists1);
            Console.Write("Merged result (Divide and Conquer): ");
            sol.PrintLinkedList(result1);
            // Expected: [1, 1, 2, 3, 4, 4, 5, 6]

            // Test 2: Priority Queue approach
            Console.WriteLine("\n2. Testing Priority Queue Approach:");
            int[] list4Values = { 1, 4, 5 };
            int[] list5Values = { 1, 3, 4 };
            int[] list6Values = { 2, 6 };
            
            ListNode list4 = sol.CreateLinkedList(list4Values);
            ListNode list5 = sol.CreateLinkedList(list5Values);
            ListNode list6 = sol.CreateLinkedList(list6Values);
            
            ListNode[] lists2 = { list4, list5, list6 };
            
            ListNode result2 = sol.MergeKListsPriorityQueue(lists2);
            Console.Write("Merged result (Priority Queue): ");
            sol.PrintLinkedList(result2);
            // Expected: [1, 1, 2, 3, 4, 4, 5, 6]

            // Test 3: Brute Force approach
            Console.WriteLine("\n3. Testing Brute Force Approach:");
            int[] list7Values = { 1, 4, 5 };
            int[] list8Values = { 1, 3, 4 };
            int[] list9Values = { 2, 6 };
            
            ListNode list7 = sol.CreateLinkedList(list7Values);
            ListNode list8 = sol.CreateLinkedList(list8Values);
            ListNode list9 = sol.CreateLinkedList(list9Values);
            
            ListNode[] lists3 = { list7, list8, list9 };
            
            ListNode result3 = sol.MergeKListsBruteForce(lists3);
            Console.Write("Merged result (Brute Force): ");
            sol.PrintLinkedList(result3);
            // Expected: [1, 1, 2, 3, 4, 4, 5, 6]

            // Test 4: Merge one by one approach
            Console.WriteLine("\n4. Testing Merge One by One Approach:");
            int[] list10Values = { 1, 4, 5 };
            int[] list11Values = { 1, 3, 4 };
            int[] list12Values = { 2, 6 };
            
            ListNode list10 = sol.CreateLinkedList(list10Values);
            ListNode list11 = sol.CreateLinkedList(list11Values);
            ListNode list12 = sol.CreateLinkedList(list12Values);
            
            ListNode[] lists4 = { list10, list11, list12 };
            
            ListNode result4 = sol.MergeKListsOneByOne(lists4);
            Console.Write("Merged result (One by One): ");
            sol.PrintLinkedList(result4);
            // Expected: [1, 1, 2, 3, 4, 4, 5, 6]

            // Test 5: LINQ approach
            Console.WriteLine("\n5. Testing LINQ Approach:");
            int[] list13Values = { 1, 4, 5 };
            int[] list14Values = { 1, 3, 4 };
            int[] list15Values = { 2, 6 };
            
            ListNode list13 = sol.CreateLinkedList(list13Values);
            ListNode list14 = sol.CreateLinkedList(list14Values);
            ListNode list15 = sol.CreateLinkedList(list15Values);
            
            ListNode[] lists5 = { list13, list14, list15 };
            
            ListNode result5 = sol.MergeKListsLinq(lists5);
            Console.Write("Merged result (LINQ): ");
            sol.PrintLinkedList(result5);
            // Expected: [1, 1, 2, 3, 4, 4, 5, 6]

            // Test 6: Empty lists
            Console.WriteLine("\n6. Testing Empty Lists:");
            ListNode[] emptyLists = { null, null, null };
            
            ListNode result6 = sol.MergeKLists(emptyLists);
            Console.Write("Merged result (Empty lists): ");
            sol.PrintLinkedList(result6);
            // Expected: null

            // Test 7: Single list
            Console.WriteLine("\n7. Testing Single List:");
            int[] singleListValues = { 1, 2, 3, 4, 5 };
            ListNode singleList = sol.CreateLinkedList(singleListValues);
            ListNode[] singleLists = { singleList };
            
            ListNode result7 = sol.MergeKLists(singleLists);
            Console.Write("Merged result (Single list): ");
            sol.PrintLinkedList(result7);
            // Expected: [1, 2, 3, 4, 5]

            // Test 8: Lists with different lengths
            Console.WriteLine("\n8. Testing Lists with Different Lengths:");
            int[] longListValues = { 1, 3, 5, 7, 9 };
            int[] shortListValues = { 2, 4 };
            int[] mediumListValues = { 0, 6, 8 };
            
            ListNode longList = sol.CreateLinkedList(longListValues);
            ListNode shortList = sol.CreateLinkedList(shortListValues);
            ListNode mediumList = sol.CreateLinkedList(mediumListValues);
            
            ListNode[] differentLengthLists = { longList, shortList, mediumList };
            
            ListNode result8 = sol.MergeKLists(differentLengthLists);
            Console.Write("Merged result (Different lengths): ");
            sol.PrintLinkedList(result8);
            // Expected: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

            // Test 9: Lists with duplicates
            Console.WriteLine("\n9. Testing Lists with Duplicates:");
            int[] list16Values = { 1, 1, 2, 3 };
            int[] list17Values = { 1, 2, 2, 4 };
            int[] list18Values = { 2, 3, 4, 5 };
            
            ListNode list16 = sol.CreateLinkedList(list16Values);
            ListNode list17 = sol.CreateLinkedList(list17Values);
            ListNode list18 = sol.CreateLinkedList(list18Values);
            
            ListNode[] duplicateLists = { list16, list17, list18 };
            
            ListNode result9 = sol.MergeKLists(duplicateLists);
            Console.Write("Merged result (With duplicates): ");
            sol.PrintLinkedList(result9);
            // Expected: [1, 1, 1, 2, 2, 2, 3, 3, 4, 4, 5]

            // Test 10: Performance comparison
            Console.WriteLine("\n10. Testing Performance Comparison:");
            Console.WriteLine("All approaches should produce the same result:");
            
            bool allEqual = sol.AreListsEqual(result1, result2) && 
                           sol.AreListsEqual(result2, result3) && 
                           sol.AreListsEqual(result3, result4) && 
                           sol.AreListsEqual(result4, result5);
            
            Console.WriteLine($"All results are equal: {allEqual}");
            // Expected: true
            Console.WriteLine();
        }
    }
} 