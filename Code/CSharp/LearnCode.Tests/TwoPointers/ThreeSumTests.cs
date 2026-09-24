using LearnCode.Core.TwoPointers;

namespace LearnCode.Tests.TwoPointers;

public class ThreeSumTests
{
    private ThreeSum _service;

    public ThreeSumTests()
    {
        _service = new ThreeSum();
    }

    [Fact]
    public void Invoke_1_Success()
    {
        int[] input = [-1, 0, 1, 2, -1, -1];
        List<(int, int, int)> expectedResults = [
            (-1,-1,2),
            (-1,0,1)
        ];

        List<(int, int, int)> results = _service.Invoke(input);

        Assert.Equivalent(expectedResults, results);
    }
}