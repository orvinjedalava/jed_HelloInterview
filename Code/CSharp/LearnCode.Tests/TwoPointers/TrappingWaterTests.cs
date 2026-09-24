using LearnCode.Core.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class TrappingWaterTests
{
    private TrappingWater _service;

    public TrappingWaterTests()
    {
        _service = new TrappingWater();
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