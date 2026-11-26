using LearnCode.Core.LinkedList.Contracts;

namespace LearnCode.Core.LinkedList;

public class Reverse
{
    public int Invoke(ListNode<int> head)
    {
        ListNode<int>? prev = null;
        ListNode<int>? current = head;

        while( current != null )
        {
            ListNode<int>? next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        return prev?.Value ?? int.MinValue;
    }
}