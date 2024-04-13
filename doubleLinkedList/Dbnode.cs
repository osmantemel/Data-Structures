namespace doubleLinkedList;

public class Dbnode<T> 
{
public Dbnode<T> Prev { get; set; }
public Dbnode<T> Next { get; set; }

public T Value { get; set; }

public Dbnode(T value)
{
    Value = value;
}

public override string ToString()
{
    return Value.ToString();
}
}
