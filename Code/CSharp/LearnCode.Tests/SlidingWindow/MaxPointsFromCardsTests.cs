using LearnCode.Core.SlidingWindow;

public class MaxPointsFromCardsTests
{
    private MaxPointsFromCards _service = null;

    public MaxPointsFromCardsTests()
    {
        _service = new MaxPointsFromCards();
    }

    [Theory]
    [InlineData(new int[] { 2,11,4,5,3,9,2 }, 3, 17)]
    [InlineData(new int[] { 5,3,8,4,7 }, 5, 27)]
    [InlineData(new int[] { 1,2,3,4,5 }, 1, 5)]
    public void Invoke_Success(int[] nums, int size, int expectedResult)
    {
        var result = _service.Invoke(nums, size);

        Assert.Equal(expectedResult, result);
    }
}