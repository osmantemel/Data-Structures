namespace singlylinkedlist;

public class singlylinkedListNode<T>
{
    public singlylinkedListNode<T> Next { get; set; }
    public T Value { get; set; }
    public singlylinkedListNode(T value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }

}
