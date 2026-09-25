using System.Reflection;
using LearnCode.Core.SlidingWindow;

namespace LearnCode.Tests.SlidingWindow;

public class VariableLengthSlidingWindowTests
{
    private VariableLengthSlidingWindow _service;

    public VariableLengthSlidingWindowTests()
    {
        _service = new VariableLengthSlidingWindow();
    }

    [Theory]
    // [InlineData(new int[] { 3,3,2,1,2,1,0 }, 4)]
    // [InlineData(new int[] { 1,4,2,6,2,1 }, 3)]
    // [InlineData(new int[] { 1,2,1,1,1,2,2,1,2 }, 9)]
    [InlineData(new int[] { 1,2,1 }, 3)]
    public void Invoke_Success(int[] nums, int expectedResult)
    {
        var result = _service.Invoke(nums);

        Assert.Equal(expectedResult, result);
    }
}