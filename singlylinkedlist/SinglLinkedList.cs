using System.Collections;
using System.Runtime.CompilerServices;

namespace singlylinkedlist;

public class SinglLinkedList<T> : IEnumerable<T>
{
    public singlylinkedListNode<T> Head { get; set; }
    private char[] arr;

    public SinglLinkedList(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            this.Add(item);
        }
    }
    public SinglLinkedList()
    {

    }
    public void Add(T value)
    {
        var node = new singlylinkedListNode<T>(value);
        node.Next = Head;
        Head = node;
    }
    public void addLast(T value)
    {
        var node = new singlylinkedListNode<T>(value);
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            singlylinkedListNode<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            curr.Next = node;
        }
    }
    // araya ekleme
    public void insertion(int index, T value)
    {
        if (index == 0)
        {
            Add(value);
        }
        else
        {
            singlylinkedListNode<T> curr = Head;
            singlylinkedListNode<T> prev = null;
            for (int i = 0; i < index - 1; i++)
            {
                prev = curr;
                curr = curr.Next;
            }
            var node = new singlylinkedListNode<T>(value);
            node.Next = curr.Next;
            prev.Next = node;
        }
    }
    public void Remove(T value)
    {
        var node = Head;
        singlylinkedListNode<T> prev = null;
        while (node != null)
        {
            if (node.Value.Equals(value))
            {
                if (prev == null)
                {
                    Head = node.Next;
                }
                else
                {
                    prev.Next = node.Next;
                }
                break;
            }
            prev = node;
            node = node.Next;
        }
    }
    public void RemoveLast()
    {
        if (Head == null)
        {
            // Bağlı listede hiç düğüm yoksa, hiçbir şey yapma
            return;
        }
        else if (Head.Next == null)
        {
            // Bağlı listede sadece bir düğüm varsa, baş düğümü sil
            Head = null;
            return;
        }

        // Son düğümü bul
        singlylinkedListNode<T> prev = null;
        singlylinkedListNode<T> curr = Head;
        while (curr.Next != null)
        {
            prev = curr;
            curr = curr.Next;
        }

        // Son düğümün referansını null yaparak sil
        prev.Next = null;
    }
    public void RemoveFirst()
    {
        if (Head != null)
        {
            singlylinkedListNode<T> oldHead = Head;
            Head = Head.Next;
            oldHead.Next = null; // Önceki baş düğümünün referansını null yap
        }
    }
    public bool Contains(T value)
    {
        var node = Head;
        while (node != null)
        {
            if (node.Value.Equals(value))
            {
                return true;
            }
            node = node.Next;
        }
        return false;
    }
    public void Print()
    {
        var node = Head;
        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Next;
        }
    }
    public void count()
    {
        int count = 0;
        var node = Head;
        while (node != null)
        {
            count++;
            node = node.Next;
        }
        Console.WriteLine("eleman sayisi :" + count);
    }
    public IEnumerator<T> GetEnumerator()
    {
        return new SinglLinkedListEnumerator<T>(Head);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
