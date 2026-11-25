using LearnCode.Core.Stack;

namespace LearnCode.Tests.Stack;

public class LargestRectangleAreaTests
{
    private LargestRectangleArea _service;

    public LargestRectangleAreaTests()
    {
        _service = new LargestRectangleArea();
    }

    [Theory]
    [InlineData(new int[] {2,8,5,6,2,3}, 15)]
    public void Invoke_Success(int[] heights, int expectedResult)
    {
        var result = _service.Invoke(heights);

        Assert.Equal(expectedResult, result);
    }
}