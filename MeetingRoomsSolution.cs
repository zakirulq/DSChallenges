
using System;
using System.Linq;

// Solution for Meeting Rooms
public class MeetingRoomsSolution
{
    public int MinMeetingRooms(int[][] intervals)
    {
        if (intervals == null || intervals.Length == 0)
        {
            return 0;
        }

        int[] startTimes = intervals.Select(i => i[0]).ToArray();
        int[] endTimes = intervals.Select(i => i[1]).ToArray();

        Array.Sort(startTimes);
        Array.Sort(endTimes);

        int rooms = 0;
        int endIndex = 0;

        for (int i = 0; i < startTimes.Length; i++)
        {
            if (startTimes[i] < endTimes[endIndex])
            {
                rooms++;
            }
            else
            {
                endIndex++;
            }
        }

        return rooms;
    }
}
