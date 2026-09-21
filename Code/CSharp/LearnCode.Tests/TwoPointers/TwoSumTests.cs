using LearnCode.Core.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class TwoSumTests
{
    private readonly TwoSum _twoSum;

    public TwoSumTests()
    {
        _twoSum = new TwoSum();
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 4, 6, 8, 10, 13 }, 13, true)]
    [InlineData(new int[] { 1, 3, 4, 6, 8, 10, 13 }, 6, false)]
    public void Output_Success(int[] input, int target, bool expectedResult)
    {
        bool result = _twoSum.Invoke(input, target);

        Assert.Equal(expectedResult, result);
    }
}