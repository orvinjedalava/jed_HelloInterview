using LearnCode.Core.Intervals;

namespace LearnCode.Tests.Intervals;

public class CanAttendMeetingsTests
{
    private readonly CanAttendMeetings _service;

    public CanAttendMeetingsTests()
    {
        _service = new CanAttendMeetings();
    }

    public static IEnumerable<object[]> TestCases = 
        new List<object[]>
        {
            new object[] { new int[][] {  new int[] {1,5}, new int[] {3,9}, new int[] {6,8}}, false},
            new object[] { new int[][] { new int[] {10,11}, new int[] {6, 10}, new int[] {1,5}} , true}
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Invoke_Success(int[][] intervals, bool expectedResult)
    {
        bool result = _service.Invoke(intervals);

        Assert.Equal(expectedResult, result);
    }
}