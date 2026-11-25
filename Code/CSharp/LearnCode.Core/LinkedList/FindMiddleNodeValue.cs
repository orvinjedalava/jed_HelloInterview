namespace LearnCode.Core.LinkedList;

public class FindMiddleNodeValue
{
    public int Invoke(LinkedListNode<int> head)
    {
        var fast = head;
        var slow = head;

        while(fast != null && fast.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow!.Next;
        }

        return slow?.Value ?? int.MinValue;
    }
}