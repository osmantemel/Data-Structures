using singlylinkedlist;
using Stack.Contract;

namespace Stack;

public class LinkedListStack<T> : IStack<T>
{
    private SinglLinkedList<T> list = new SinglLinkedList<T>();
    public int count => list.Count;

    public bool isEmpty => list.Count == 0;

    public void Clear()
    {
        list.Clear();
        count=0;
    }

    public T Peek()
    {
        if (isEmpty)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return list.Head.Value;
    }

    public T Pop()
    {
        if (isEmpty)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T value = list.Head.Value;
        list.RemoveLast();
        count--;
        return value;
    }

    public void Push(T value)
    {
        list.AddFirst(value);
        count++;
    }

    public static implicit operator Stack<T>(LinkedListStack<T> v)
    {
        Stack<T> stack = new Stack<T>();
        var node = v.list.Head;
        while (node != null)
        {
            stack.Push(node.Value);
            node = node.Next;
        }
        return stack;
    }
}
