using LearnCode.Core.Stack;

namespace LearnCode.Tests.Stack;

public class LongestValidParenthesesTests
{
    private readonly LongestValidParentheses _service;

    public LongestValidParenthesesTests()
    {
        _service = new LongestValidParentheses();
    }

    [Theory]
    [InlineData("())))", 2)]
    [InlineData("((()()())", 8)]
    [InlineData("",0)]
    public void Invoke_Success(string s, int expectedResult)
    {
        int result = _service.Invoke(s);
  
        Assert.Equal(expectedResult, result);
    }
}