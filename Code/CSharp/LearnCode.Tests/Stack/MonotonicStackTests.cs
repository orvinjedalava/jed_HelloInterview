using LearnCode.Core;
using LearnCode.Core.Stack;

namespace LearnCode.Tests.Stack;

public class MonotonicStackTests
{
    private readonly MonotonicStack _service;

    public MonotonicStackTests()
    {
        _service = new MonotonicStack();
    }

    [Theory]
    [InlineData(new int[] {102,101,103,102,104,103}, new int[] {103,103,104,104,-1,-1})]
    [InlineData(new int[] {2,1,2,3,1,2}, new int[] {3,2,3,-1,2,-1})]
    public void Invoke_Success(int[] nums, int[] expectedResult)
    {
        int[] result = _service.Invoke(nums);

        Assert.Equal(expectedResult, result);
    }
}