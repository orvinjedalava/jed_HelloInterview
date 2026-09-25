using LearnCode.Core.SlidingWindow;

namespace LearnCode.Tests.SlidingWindow;

public class LongestSubstringNoRepeatingCharsTests
{
    private LongestSubstringNoRepeatingChars _service;

    public LongestSubstringNoRepeatingCharsTests()
    {
        _service = new LongestSubstringNoRepeatingChars();
    }

    [Theory]
    [InlineData("eghghhgg", new string[] { "egh" })]
    [InlineData("abcbcab", new string[] { "abc", "bca", "cab" })]
    [InlineData("abcdefb", new string[] { "abcdef" })]
    public void Invoke_Success(string s, string[] expectedResult)
    {
        var result = _service.Invoke(s);

        Assert.Equal([.. expectedResult], result);
    }
}

