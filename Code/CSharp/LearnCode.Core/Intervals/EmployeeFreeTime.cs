using System.Net.Http.Headers;

namespace LearnCode.Core.Intervals;
/*

Write a function to find the common free time for all employees from a list called schedule. Each employee's schedule is a list of non-overlapping intervals, sorted by start time, representing the times that employee is busy (their meetings). The function should return the finite, non-zero length intervals during which every employee is free, sorted in order. Free time is the gaps that sit between busy periods once all the schedules are combined. There's no fixed workday here, so time before everyone's first meeting or after everyone's last doesn't count — that's what "finite" means.

Input:

schedule = [[[2,4],[7,10]],[[1,5]],[[6,9]]]
Output:

[[5,6]]
Explanation: The three employees collectively have only one common free time interval, which is from 5 to 6.

*/

public class EmployeeFreeTime
{
    public int[][] Invoke(int[][][] schedule)
    {
        // flatten all schedules for all employees
        List<int[]> flattened = [];

        foreach(var employee in schedule)
        {
            foreach(var interval in employee)
            {
                flattened.Add(interval);
            }
        }

        // sort by start time ASC. Guarantees overlapping intervals as neighbors
        flattened.Sort((a,b) => a[0] - b[0]);

        List<int[]> merged = [];

        // merge intervals that overlap each other
        foreach(int[] interval in flattened)
        {
            if (merged.Count == 0 || merged[merged.Count - 1][1] < interval[0])
            {
                merged.Add(interval);
            }
            else
            {
                merged[merged.Count -1][1] = int.Max(merged[merged.Count - 1][1], interval[1]);
            }
        }

        // take the free times
        List<int[]> freeTimes = [];

        for (int i = 1; i < merged.Count; i++)
        {
            int start = merged[i - 1][1];
            int end = merged[i][0];
            freeTimes.Add([start, end]);
        }

        return [.. freeTimes];
    }
}