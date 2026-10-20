namespace LearnCode.Core.Intervals;

public class CanAttendMeetings
{
    public bool Invoke(int[][] intervals)
    {
        if (intervals.Length == 0)
            return true;

        Array.Sort(intervals, (a,b) => a[0] - b[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[i-1][1])
                return false;
        }

        return true;

    }
}