using LearnCode.Core.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class TrappingRainWaterTests
{
    private TrappingRainWater _service;

    public TrappingRainWaterTests()
    {
        _service = new TrappingRainWater();
    }

    [Theory]
    [InlineData(new int[] { 3,4,1,2,2,5,1,0,2}, 10)]
    [InlineData(new int[] { 1,2,3,4,5,1,4}, 3 )]
    public void Invoke_Success(int[] nums, int expectedResult)
    {
        var result = _service.Invoke(nums);

        Assert.Equal(expectedResult, result);
    }
}