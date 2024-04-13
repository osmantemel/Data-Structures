using System.Collections;

namespace doubleLinkedList;

public class DoublyLinkedListEnumerator<T> : IEnumerator<T>
{
    private Dbnode<T> _currentNode;
    private DoublyLinkedList<T> _list;

    public DoublyLinkedListEnumerator(DoublyLinkedList<T> list)
    {
        _list = list;
        _currentNode = null;
    }

    public T Current
    {
        get
        {
            if (_currentNode == null)
            {
                throw new InvalidOperationException("Enumerator is before the first element or after the last element of the collection.");
            }
            return _currentNode.Value;
        }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _currentNode = null;
        _list = null;
    }

    public bool MoveNext()
    {
        if (_currentNode == null)
        {
            _currentNode = _list.Head;
        }
        else
        {
            _currentNode = _currentNode.Next;
        }

        return _currentNode != null;
    }

    public void Reset()
    {
        _currentNode = null;
    }
}