using System;
using System.Collections.Generic;
using singlylinkedlist;

class Program
{
    static void Main(string[] args)
    {
        var a = new SinglLinkedList<int>();

        a.Add(1);
        a.Add(2);
        a.Add(3);
        a.Add(4);
        a.Add(5);
        a.Add(6);
        a.Add(7);
        a.addLast(15);
        a.Remove(2);
        a.insertion(3, 100);
        a.RemoveFirst();
        a.RemoveLast();

        a.Print();

        int count = a.Count();
        Console.WriteLine("Eleman sayısı: " + count);
    }

    static void singly()
    {
        var a = new SinglLinkedList<int>();

        a.Add(1);
        a.Add(2);
        a.Add(3);
        a.Add(4);
        a.Add(5);
        a.Add(6);
        a.Add(7);
        a.addLast(15);
        a.Remove(2);
        a.insertion(3, 100);
        a.RemoveFirst();
        a.RemoveLast();

        a.Print();

        int count = a.Count();
        Console.WriteLine("Eleman sayısı: " + count);
    }
}
