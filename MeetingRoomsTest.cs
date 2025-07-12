using System;

public class MeetingRoomsTest
{
    public static void TestMeetingRooms()
    {
        Console.WriteLine("--- Testing Meeting Rooms ---");
        MeetingRoomsSolution sol = new MeetingRoomsSolution();
        
        int[][] intervals1 = new int[][]
        {
            new int[] {0, 30},
            new int[] {5, 10},
            new int[] {15, 20}
        };
        int result1 = sol.MinMeetingRooms(intervals1);
        Console.WriteLine("Minimum meeting rooms required for [[0, 30], [5, 10], [15, 20]]: " + result1); // Expected: 2

        int[][] intervals2 = new int[][]
        {
            new int[] {7, 10},
            new int[] {2, 4}
        };
        int result2 = sol.MinMeetingRooms(intervals2);
        Console.WriteLine("Minimum meeting rooms required for [[7, 10], [2, 4]]: " + result2); // Expected: 1
        Console.WriteLine();
    }
} 