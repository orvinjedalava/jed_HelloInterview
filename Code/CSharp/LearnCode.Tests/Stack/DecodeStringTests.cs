using LearnCode.Core.Stack;

namespace LearnCode.Tests.Stack;

public class DecodeStringTests
{
    private readonly DecodeString _service;

    public DecodeStringTests()
    {
        _service = new DecodeString();
    }

    [Theory]
    [InlineData("3[a]2[bc]","aaabcbc")]
    [InlineData("ababab", "ababab")]
    [InlineData("5[m]abc4[j]","mmmmmabcjjjj")]
    public void Invoke_Success(string s, string expectedResult)
    {
        string result = _service.Invoke(s);

        Assert.Equal(expectedResult, result);
    }
}