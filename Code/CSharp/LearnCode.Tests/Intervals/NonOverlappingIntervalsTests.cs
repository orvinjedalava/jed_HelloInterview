using LearnCode.Core.Intervals;

namespace LearnCode.Tests.Intervals;

public class NonOverlappingIntervalsTests
{
    private readonly NonOverlappingIntervals _service;

    public NonOverlappingIntervalsTests()
    {
        _service = new NonOverlappingIntervals();
    }

    public static readonly IEnumerable<object[]> TestCases =
    [
        [ new int[][] { [1,3],[5,8],[4,10],[11,13] }, 1],
        [ new int[][] { [1,10], [2,9], [3,4], [4,4], [6,8], [9,10]}, 2]
    ];

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Invoke_Success(int[][] intervals, int expectedResult)
    {
        int result = _service.Invoke(intervals);

        Assert.Equal(expectedResult, result);
    }
}