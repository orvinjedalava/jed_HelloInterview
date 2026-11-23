using LearnCode.Core.Stack;

namespace LearnCode.Tests.Stack;

public class DailyTemperatureTests
{
    private readonly DailyTemperatures _service;

    public DailyTemperatureTests()
    {
        _service = new DailyTemperatures();
    }

    [Theory]
    [InlineData(new int[] {65,70,68,60,55,75,80,74}, new int[] {1,4,3,2,1,1,0,0})]
    public void Invoke_Success(int[] temps, int[] expectedResult)
    {
        var result = _service.Invoke(temps);

        Assert.Equal(expectedResult, result);
    }
}