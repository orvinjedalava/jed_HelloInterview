using System.Collections;

namespace LearnCode.Core.LinkedList.Contracts;

public class SinglyLinkedList<T> : IEnumerable<T>
{
    public ListNode<T>? Head { get; set; }
    public ListNode<T>? Tail { get; private set; }

    public SinglyLinkedList() { }

    public SinglyLinkedList(IEnumerable<T> values)
    {
        foreach (var value in values)
            AddLast(value);
    }

    public ListNode<T> AddFirst(T value)
    {
        var node = new ListNode<T>(value, Head);
        Head = node;
        Tail ??= node;
        return node;
    }

    public ListNode<T> AddLast(T value)
    {
        var node = new ListNode<T>(value);
        if (Head is null)
        {
            Head = Tail = node;
        }
        else
        {
            Tail!.Next = node;
            Tail = node;
        }
        return node;
    }

    // Wraps a node returned by an algorithm (e.g. a reversed head) so it can be enumerated.
    public static SinglyLinkedList<T> FromHead(ListNode<T>? head)
    {
        var list = new SinglyLinkedList<T> { Head = head };
        var current = head;
        while (current?.Next != null)
            current = current.Next;
        list.Tail = current;
        return list;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var current = Head; current != null; current = current.Next)
            yield return current.Value;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}