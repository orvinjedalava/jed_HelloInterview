using LearnCode.Core.Intervals;

namespace LearnCode.Tests.Intervals;

public class MergeIntervalsTests
{
    private readonly MergeIntervals _service;

    public MergeIntervalsTests()
    {
        _service = new MergeIntervals();
    }

    public static readonly IEnumerable<object[]> TestCases =
        [
            [ new int[][] {[3,5],[1,4],[7,9], [6,8]}, new int[][] {[1,5],[6,9]}],
            [ new int[][] {[1,5], [3,5], [6,10], [7,8]}, new int[][] {[1,5], [6,10]}]
        ];
    
    [Theory]
    [MemberData(nameof(TestCases))]
    public void Invoke_Success(int[][] intervals, int[][] expectedResult) 
    {
        int[][] result = _service.Invoke(intervals);

        Assert.Equal(expectedResult, result);
    }
}