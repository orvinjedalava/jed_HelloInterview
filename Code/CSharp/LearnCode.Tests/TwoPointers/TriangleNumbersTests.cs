using LearnCode.Code.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class TriangleNumbersTests
{
    private TriangleNumbers _service;

    public TriangleNumbersTests()
    {
        _service = new TriangleNumbers();
    }

    [Theory]
    [InlineData(new int[] { 11, 4, 9, 6, 15, 18 }, 10)]
    [InlineData(new int[] { 5, 2, 3, 7 }, 1)]
    [InlineData(new int[] { 1, 2, 10 }, 0)]
    public void Invoke_Success(int[] nums, int expectedResult)
    {
        int result = _service.Invoke(nums);

        Assert.Equal(expectedResult, result);
    }
}