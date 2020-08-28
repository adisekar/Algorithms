using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Arrays.Intervals
{
    public class MeetingRooms
    {
        // Meeting Rooms
        // [[7,10], [2,4]] -> start and end time
        public static bool CanAttendMeetings(int[][] intervals)
        {
            var sortedIntervalsByStartTime = intervals.OrderBy(i => i[0]).ToArray();
            for (int i = 0; i < sortedIntervalsByStartTime.Length - 1; i++)
            {
                if (sortedIntervalsByStartTime[i][1] > sortedIntervalsByStartTime[i + 1][0])
                {
                    return false;
                }
            }
            return true;
        }

        // Meeting Rooms 2 Leetcode
        // [[7,10], [2,4]] -> start and end time
        public static int MinMeetingRooms_BF(int[][] intervals)
        {
            if (intervals.Length == 0) { return 0; }
            int minMeetingRooms = 1;
            var sortedIntervalsByStartTime = intervals.OrderBy(i => i[0]).ToList();
            for (int i = 0; i < intervals.Length; i++)
            {
                int tempRoom = 1;
                for (int j = 0; j < i; j++)
                {
                    // If current interval start time is less than
                    // every other interval end time, and
                    // current interval start time is greater/== than
                    // every other start time
                    if (i != j && intervals[i][0] < intervals[j][1] && intervals[i][0] >= intervals[j][0])
                    {
                        tempRoom++;
                    }
                }
                minMeetingRooms = Math.Max(tempRoom, minMeetingRooms);
            }
            return minMeetingRooms;
        }

        public static int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 0) { return 0; }
            int minMeetingRooms = 0;
            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                startTimes[i] = intervals[i][0];
                endTimes[i] = intervals[i][1];
            }

            Array.Sort(startTimes);
            Array.Sort(endTimes);

            int sPtr = 0;
            int ePtr = 0;
            while (sPtr < startTimes.Length && ePtr < endTimes.Length)
            {
                // If there is a meeting that has ended by the time the meeting at `start_pointer` starts
                if (startTimes[sPtr] >= endTimes[ePtr])
                {
                    minMeetingRooms -= 1;
                    ePtr++;
                }

                // We do this irrespective of whether a room frees up or not.
                // If a room got free, then this used_rooms += 1 wouldn't have any effect. used_rooms would
                // remain the same in that case. If no room was free, then this would increase used_rooms
                minMeetingRooms++;
                sPtr++;
            }
            return minMeetingRooms;
        }
    }
}
