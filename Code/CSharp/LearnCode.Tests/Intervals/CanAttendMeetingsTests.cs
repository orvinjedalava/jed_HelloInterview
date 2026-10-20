using LearnCode.Core.Intervals;

namespace LearnCode.Tests.Intervals;

public class CanAttendMeetingsTests
{
    private readonly CanAttendMeetings _service;

    public CanAttendMeetingsTests()
    {
        _service = new CanAttendMeetings();
    }

    public static readonly IEnumerable<object[]> TestCases = 
        [
            [new int[][] { [1,5], [3,9], [6,8]}, false],
            [new int[][] { [10,11], [6, 10], [1,5]} , true]
        ];

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Invoke_Success(int[][] intervals, bool expectedResult)
    {
        bool result = _service.Invoke(intervals);

        Assert.Equal(expectedResult, result);
    }
}