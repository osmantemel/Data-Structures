using System.Collections;

namespace singlylinkedlist;
public class SinglLinkedListEnumerator<T> : IEnumerator<T>
{
    private singlylinkedListNode<T> Head;
    private singlylinkedListNode<T> _current;

    public SinglLinkedListEnumerator(singlylinkedListNode<T> head)
    {
        Head = head;
        _current= null;
    }
    public T Current => _current.Value;

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        Head = null;
    }

    public bool MoveNext()
    {
        if (_current == null)
        {
            _current = Head;
        }
        else
        {
            _current = _current.Next;
        }
        return _current!= null;
    }

    public void Reset()
    {
        _current = null;
    }
}