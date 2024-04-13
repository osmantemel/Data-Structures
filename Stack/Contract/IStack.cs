using System.Runtime.CompilerServices;

namespace Stack.Contract;

public interface IStack<T>
{
    int count { get; }
    void Push(T value);
    T Peek();
    T Pop();
    bool isEmpty { get; }
    void Clear();
}