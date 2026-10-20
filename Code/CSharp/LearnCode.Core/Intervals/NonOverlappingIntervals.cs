using System.Runtime.ExceptionServices;

namespace LearnCode.Core.Intervals;

/*

Write a function to return the minimum number of intervals that must be removed from a given array intervals, where intervals[i] consists of a starting point starti and an ending point endi, to ensure that the remaining intervals do not overlap. Intervals that only touch at their endpoints are not considered overlapping (e.g., [2,5] and [5,7] do not overlap).

Input:

intervals = [[1,3],[5,8],[4,10],[11,13]]
Output:

1
Explanation: Removing the interval [4,10] leaves all other intervals non-overlapping.

*/
public class NonOverlappingIntervals
{
    public int Invoke(int[][] intervals)
    {
        if (intervals.Length == 0)
            return 0;

        // sort the intervals by ascending order of their ending numbers
        Array.Sort(intervals, (a,b) => a[1] - b[1]);

        int end = intervals[0][1];
        int count = 1;

        for(int i = 1; i < intervals.Length; i++)
        {
            // if current interval does not overlap the last interval in the list, add it and adjust the new max end
            if (intervals[i][0] >= end)
            {
                end = intervals[i][1];
                count++;
            } 
        }

        return intervals.Length - count;
    }
}