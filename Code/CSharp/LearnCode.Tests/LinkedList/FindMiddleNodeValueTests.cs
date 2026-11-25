using LearnCode.Core.LinkedList;

namespace LearnCode.Tests.LinkedList;

public class FindMiddleNodeValueTests
{
    private readonly FindMiddleNodeValue _service;

    public FindMiddleNodeValueTests()
    {
        _service = new FindMiddleNodeValue();
    }

    // private LinkedList<int> GenerateIntLinkedList(int[] inputs)
    // {
    //     new LinkedList<int>(inputs);

        

    //     return result;
    // }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5}, 3)]
    [InlineData(new int[] { 1, 2, 3, 4}, 3)]
    public void Invoke_Success(int[] inputs, int expectedResult)
    {
        var linkedList = new LinkedList<int>(inputs);

        var result = _service.Invoke(linkedList.First!);

        Assert.Equal(expectedResult, result);
    }
}