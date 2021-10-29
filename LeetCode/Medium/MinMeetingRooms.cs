using System;

namespace CodingAlgorithms.LeetCode.Medium
{
    public class MinMeetingRooms
    {
        public int Calculate(int[][] intervals)
        {
            if(intervals.GetLength(0) == 0) return 0;

            int[] startTimes = new int[intervals.GetLength(0)];
            int[] endTimes = new int[intervals.GetLength(0)];

            for(int i=0;i<intervals.GetLength(0); i++)
            {
                startTimes[i] = intervals[i][0];
                endTimes[i] = intervals[i][1];
            }

            Array.Sort(startTimes, (int a, int b) => { return a-b; });
            Array.Sort(endTimes, (int a, int b) => { return a-b; });

            int roomsUsed = 0;
            int startPointer = 0, endPointer = 0;

            while(startPointer < intervals.GetLength(0))
            {
                // This tells us whether a room has freed up or not
                if(startTimes[startPointer] >= endTimes[endPointer])
                {
                    roomsUsed--;
                    endPointer += 1;
                }

                roomsUsed++;
                startPointer++;
            }

            return roomsUsed;
        }
    }
}