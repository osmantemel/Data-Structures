using System;
using System.Collections.Generic;
using doubleLinkedList;
using singlylinkedlist;

class Program
{
    static void Main(string[] args)
    {


    }

    static void doubly()
    {
        var a = new DoublyLinkedList<int>(); 
        a.Add(15);
        a.Add(20);
        a.Add(25);
        a.Add(30);
        a.Add(35);
        a.Add(40);
        a.addBefore(45 , 0);
        a.AddLast(99);
        a.Remove(99);
        a.RemoveIndex(0);
        a.Print();
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
