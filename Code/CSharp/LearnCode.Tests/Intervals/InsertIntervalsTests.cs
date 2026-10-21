using LearnCode.Core.Intervals;

namespace LearnCode.Tests.Intervals;

public class InsertIntervalsTests
{
    private readonly InsertIntervals _service;

    public InsertIntervalsTests()
    {
        _service = new InsertIntervals();
    }

    public static readonly IEnumerable<object[]> TestCases =
    [
        [ new int[][] { [1,2], [3,5], [6,7], [8,10] }, new int[] {5,6}, new int[][] { [1,2], [3,7], [8,10]}],
        [ new int[][] { [1,5], [6,7], [8,8], [16,20]}, new int[] {6,15}, new int[][] { [1,5], [6,15], [16,20]}],
        [ new int[][] { [1,5], [6,7], [8,8], [16,20]}, new int[] {8,18}, new int[][] { [1,5], [6,7], [8,20]}],
        [ new int[][] {}, new int[] {12,16}, new int[][] { [12,16] }]
    ];

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Invoke_Success(int[][] intervals, int[] newInterval, int[][] expectedResult)
    {
        int[][] result = _service.Invoke(intervals, newInterval);

        Assert.Equal(expectedResult, result);
    }
}