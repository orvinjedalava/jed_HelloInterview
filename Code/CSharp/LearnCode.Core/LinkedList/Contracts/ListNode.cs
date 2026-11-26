namespace LearnCode.Core.LinkedList.Contracts;

public class ListNode<T>
{
    public T Value { get; set; }
    public ListNode<T>? Next { get; set; }

    public ListNode(T value, ListNode<T>? next = null)
    {
        Value = value;
        Next = next;
    }
}