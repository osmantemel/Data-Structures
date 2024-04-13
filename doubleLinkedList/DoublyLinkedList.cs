using System.Collections;

namespace doubleLinkedList;

public class DoublyLinkedList<T> :IEnumerable
{
    public Dbnode<T> Head { get; set; }
    public Dbnode<T> Tail { get; set; }

    public DoublyLinkedList()
    {
        
    }
    public DoublyLinkedList(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            this.Add(item);
        }
    }
    public void Add(T item)
    {
        var newNode = new Dbnode<T>(item);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
    }
    public void AddFirst(T item)
    {
        var newNode = new Dbnode<T>(item);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }
    }
    public void AddLast(T item)
    {
        var newNode = new Dbnode<T>(item);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Dbnode<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            curr.Next = newNode;
            Tail = newNode;
        }
    }
    public void insertion(T value, int index)
    {
        if (index == 0)
        {
            AddFirst(value);
        }
        else
        {
            Dbnode<T> curr = Head;
            for (int i = 0; i < index - 1; i++)
            {
                curr = curr.Next;
            }
            var newNode = new Dbnode<T>(value);
            newNode.Next = curr.Next;
            curr.Next = newNode;
        }
    }
    public void addBefore(T value, int index)
    {
        Dbnode<T> curr = Head;
        for (int i = 0; i < index - 1; i++)
        {
            curr = curr.Next;
        }
        var newNode = new Dbnode<T>(value);
        newNode.Next = curr.Next;
        curr.Next = newNode;
    }
    public void Remove(T value)
    {
        Dbnode<T> prev = null;
        Dbnode<T> curr = Head;
        while (curr != null)
        {
            if (curr.Value.Equals(value))
            {
                if (prev == null)
                {
                    Head = curr.Next;
                }
                else
                {
                    prev.Next = curr.Next;
                }
                break;
            }
            prev = curr;
            curr = curr.Next;
        }
    }
    public void RemoveIndex(int index)
    {
        if (index < 0)
        {
            // Geçersiz indeks
            Console.WriteLine("Hata: Geçersiz indeks.");
            return;
        }
        else if (index == 0)
        {
            // İlk düğümü kaldır
            RemoveFirst();
            return;
        }

        Dbnode<T> prev = null;
        Dbnode<T> curr = Head;
        int count = 0;

        // Belirtilen indekse kadar ilerle
        while (curr != null && count < index)
        {
            prev = curr;
            curr = curr.Next;
            count++;
        }

        if (curr == null)
        {
            // Belirtilen indeks listede bulunamadı
            Console.WriteLine("Hata: Belirtilen indeks listede bulunamadı.");
            return;
        }

        // Belirtilen indeksteki düğümü kaldır
        prev.Next = curr.Next;

        // Eğer belirtilen indeksteki düğüm liste son düğümü ise, Tail'i güncelle
        if (curr == Tail)
        {
            Tail = prev;
        }
    }
    public void RemoveFirst()
    {
        if (Head != null)
        {
            Dbnode<T> oldHead = Head;
            Head = Head.Next;
            oldHead.Next = null; // Önceki baş düğümünün referansını null yap
        }
    }
    public void RemoveLast()
    {
        if (Head == null)
        {
            // Liste boş, hiçbir şey yapma
            return;
        }
        else if (Head.Next == null)
        {
            // Liste tek elemanlı, baş düğümü kaldır
            Head = null;
            Tail = null;
            return;
        }

        Dbnode<T> curr = Head;
        Dbnode<T> prev = null;

        while (curr.Next != null)
        {
            prev = curr;
            curr = curr.Next;
        }

        // Son düğümü kaldır
        prev.Next = null;
        Tail = prev;
    }
    public void Print()
    {
        Dbnode<T> curr = Head;
        while (curr != null)
        {
            Console.Write($"{curr.Value} -> ");
            curr = curr.Next;
        }
        Console.WriteLine(); // Satır sonuna ekstra bir boşluk bırak
    }
    private List<Dbnode<T>> getAllNodes()
    {
     var list = new List<Dbnode<T>>();
     var curr = Head;
     while (curr!= null)
     {
         list.Add(curr);
         curr = curr.Next;
     }
     return list;

    }
    public IEnumerator GetEnumerator()
    {
       return getAllNodes().GetEnumerator();
    }
}
