using LearnCode.Core.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class MoveZeroesTests
{
    private MoveZeroes _service;

    public MoveZeroesTests()
    {
        _service = new MoveZeroes();
    }

    [Theory]
    [InlineData(new int[] {2,0,4,0,9}, new int[] {2,4,9,0,0})]
    [InlineData(new int[] {2,2,4,1,9}, new int[] {2,2,4,1,9})]
    public void Invoke_Success(int[] nums, int[] expectedResult)
    {
        _service.Invoke(nums);

        Assert.Equal(expectedResult, nums);
    }
}