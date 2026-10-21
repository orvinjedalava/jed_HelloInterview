using System.Reflection;

namespace LearnCode.Core.Intervals;

/*

You're given a list of intervals intervals that is already sorted by start time and has no overlaps, plus a single interval newInterval. Write a function that returns a new list containing all the intervals after newInterval has been inserted. The returned list must stay sorted by start time and have no overlaps, so any intervals that overlap once newInterval is added should be merged together. You don't need to modify intervals in place; just build and return the result.

Two intervals are considered overlapping if they share any common time, including if one ends exactly when another begins (e.g., [1,4] and [4,7] overlap and should be merged into [1,7]).

Input:

intervals = [[1,3],[6,9]]
newInterval = [2,5]
Output:

[[1,5],[6,9]]
Explanation: The new interval [2,5] overlaps with [1,3], so they are merged into [1,5].

Input:

intervals = [[1,2],[3,5],[6,7],[8,10]]
newInterval = [5,6]
Output:

[[1,2],[3,7],[8,10]]
Explanation: The new interval [5,6] touches [3,5] and [6,7], so all three are merged into [3,7].

*/
public class InsertIntervals
{
    public int[][] Invoke(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
            return [.. new List<int[]>() {newInterval}];

        Array.Sort(intervals, (a,b) => a[1] - b[1]);

        List<int[]> merged = [];
        bool newIntervalAdded = false;

        for(int i = 0; i < intervals.Length; i++)
        {
            // if current interval is on the left of newInterval, add it to the merged list
            if (intervals[i][1] < newInterval[0])
            {
                merged.Add(intervals[i]);
            }
            // if current interval is touching newInterval, set the new min[0] and max[1] of newInterval
            else if (
                intervals[i][1] >= newInterval[0]
                && intervals[i][0] <= newInterval[1]
            )
            {
                newInterval[0] = int.Min(intervals[i][0], newInterval[0]);
                newInterval[1] = int.Max(intervals[i][1], newInterval[1]);
            }
            else // if current interval is on the right of newInterval, add it to merged list
            {
                if (!newIntervalAdded) // first time we reach this condition, add the new newInterval values once
                {
                    newIntervalAdded = true;
                    merged.Add(newInterval);
                }
                merged.Add(intervals[i]);
            }
        }

        if (!newIntervalAdded)
            merged.Add(newInterval);

        return [.. merged];
    }
}