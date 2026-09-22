using LearnCode.Core.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class ContainerWithMostWaterTests
{
    private ContainerWithMostWater _service;

    public ContainerWithMostWaterTests()
    {
        _service = new ContainerWithMostWater();
    }

    [Theory]
    [InlineData(new int[] {3,4,1,2,2,4,1,3,2}, 21)]
    [InlineData(new int[] {1,2,1}, 2)]
    public void Invoke_Success(int[] heights, int expectedResult)
    {
        int result = _service.Invoke(heights);

        Assert.Equal(expectedResult, result);
    }
}