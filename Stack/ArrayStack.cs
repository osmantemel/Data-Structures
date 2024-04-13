using Stack.Contract;

namespace Stack;
public class ArrayStack<T> : IStack<T>
{
    public int count { get; private set; }

    private readonly List<T> list = new List<T>();

    public bool isEmpty => count == 0;

    public void Clear()
    {
        list.Clear();
        count = 0;
    }

    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return list[list.Count - 1];
    }

    public T Pop()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        var item = list[count - 1];
        list.RemoveAt(count - 1);
        count--;
        return item;
    }

    public void Push(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }
        list.Add(value);
        count++;
    }

    public static implicit operator Stack<T>(ArrayStack<T> v)
    {
        Stack<T> stack = new Stack<T>();
        for (int i = v.count - 1; i >= 0; i--)
        {
            stack.Push(v.list[i]);
        }
        return stack;
    }
}
