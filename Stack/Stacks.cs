using Stack.Contract;

namespace Stack;

public class Stacks<T>
{
    private readonly Stack<T> stack;
    public int Count => stack.Count;
    public Stacks(StackType type = StackType.Array)
    {
        if (type == StackType.Array)
        {
            stack = new ArrayStack<T>();
        }else
        {
            stack = new LinkedListStack<T>();
        }
    }

    public T Pop()
    {
        return stack.Pop();
    }
    public void Push(T value)
    {
        stack.Push(value);
    }
    public T Peek()
    {
        return stack.Peek();
    }
    public void Clear()
    {
        stack.Clear();
    }
  
}



public enum StackType
{
    Array=0, // List<T>
    LinkedList= 1 // SinglyLinkedList<T>
}