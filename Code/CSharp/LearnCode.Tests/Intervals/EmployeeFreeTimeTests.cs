using LearnCode.Core.Intervals;

namespace LearnCode.Tests.Intervals;

public class EmployeeFreeTimeTests
{
    private readonly EmployeeFreeTime _service;

    public EmployeeFreeTimeTests()
    {
        _service = new EmployeeFreeTime();
    }

    public static IEnumerable<object[]> TestCases =
    [
        [ new int[][][] { [[2,4], [7,10]], [[1,5], [6,9]]}, new int[][] { [5,6]} ]
    ];

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Invoke_Success(int[][][] schedule, int[][] expectedResult)
    {
        int[][] result = _service.Invoke(schedule);

        Assert.Equal(expectedResult, result);
    }
}