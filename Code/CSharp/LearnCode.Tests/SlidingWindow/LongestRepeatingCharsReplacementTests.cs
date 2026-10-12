using LearnCode.Core.SlidingWindow;

namespace LearnCode.Tests;

public class LongestRepeatingCharsReplacementTests
{
    private LongestRepeatingCharsReplacement _service;

    public LongestRepeatingCharsReplacementTests()
    {
        _service = new LongestRepeatingCharsReplacement();
    }

    [Theory]
    [InlineData("BBABCCDD", 2, 5)]
    public void Invoke_Success(string s, int k, int expectedResult)
    {
        var result = _service.Invoke(s, k);

        Assert.Equal(expectedResult, result);
    }
}