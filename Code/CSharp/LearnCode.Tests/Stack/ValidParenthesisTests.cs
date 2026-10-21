using LearnCode.Core.Stack;

namespace LearnCode.Tests.Stack;

public class ValidParenthesisTests
{
    private readonly ValidParenthesis _service;

    public ValidParenthesisTests()
    {
        _service = new ValidParenthesis();
    }

    [Theory]
    [InlineData("(){({})}", true)]
    [InlineData("{(())}", true)]
    [InlineData("{}(()", false)]
    [InlineData("(){({}})", false)]                   
    public void Invoke_Success(string s, bool expectedResult)
    {
        bool result = _service.Invoke(s);

        Assert.Equal(expectedResult, result);
    }
}