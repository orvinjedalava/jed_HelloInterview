using LearnCode.Core.SlidingWindow;

namespace LearnCode.Tests.SlidingWindow;

public class MaxSumOfDistinctSubarraysTests
{
    private MaxSumOfDistinctSubarrays _service;

    public MaxSumOfDistinctSubarraysTests()
    {
        _service = new MaxSumOfDistinctSubarrays();
    }

    [Theory]
    //[InlineData(new int[] { 3,2,2,3,4,6,7,7,-1}, 4, 20)]
    [InlineData(new int[] { 5,5,5,5,5}, 3, 0)]
    public void Invoke_Success(int[] nums, int size, int expectedResult)
    {
        var result = _service.Invoke(nums, size);

        Assert.Equal(expectedResult, result);
    }
}