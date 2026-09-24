using LearnCode.Core.SlidingWindow;

namespace LearnCode.Tests.SlidingWindow;

public class MaxSubarraySumTests
{
    private MaxSubarraySum _service;

    public MaxSubarraySumTests()
    {
        _service = new MaxSubarraySum();
    }

    [Theory]
    [InlineData(new int[] { 2,1,5,1,3,2 }, 3, 9)]
    [InlineData(new int[] { 1,2,3,4,5,4,3,2,1}, 4, 16)]
    [InlineData(new int[] { 4,1,-1,-6,2 }, 1, 4)]
    [InlineData(new int[] { -1,-2,-3,-4,-3,-2,-1}, 3, -6)]
    public void Invoke_Success(int[] nums, int size, int expectedResult)
    {
        var result = _service.Invoke(nums, size);

        Assert.Equal(expectedResult, result);
    }
}