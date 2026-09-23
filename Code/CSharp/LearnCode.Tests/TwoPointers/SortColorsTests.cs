using LearnCode.Core.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class SortColorsTests
{
    private SortColors _service;

    public SortColorsTests()
    {
        _service = new SortColors();
    }

    [Theory]
    [InlineData(new int[] { 2,1,2,0,1,0,1,0,1 }, new int[] { 0,0,0,1,1,1,1,2,2 })]
    [InlineData(new int[] { 0,1,2,0,1,2 }, new int[] {0,0,1,1,2,2 })]
    public void Invoke_Success(int[] nums, int[] expectedResult)
    {
        _service.Invoke(nums);

        Assert.Equal(expectedResult, nums);
    }
}