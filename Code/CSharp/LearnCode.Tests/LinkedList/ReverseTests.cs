using LearnCode.Core.LinkedList;
using LearnCode.Core.LinkedList.Contracts;

namespace LearnCode.Tests.LinkedList;

public class ReverseTests
{
    private readonly Reverse _service;

    public ReverseTests()
    {
        _service = new Reverse();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new int[] { 5, 8, 2, 1, 4}, 4)]
    public void Invoke_Success(int[] inputs, int expectedResult)
    {
        var linkedList = new SinglyLinkedList<int>(inputs);
        var result = _service.Invoke(linkedList.Head!);

        Assert.Equal(expectedResult, result);
    }
}