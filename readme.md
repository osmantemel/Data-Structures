# Bağlı Liste (Linked List) Implementasyonu

Bu proje, C# programlama dili kullanılarak çift yönlü ve tek yönlü bağlı liste veri yapılarının basit bir implementasyonunu içermektedir. Bağlı liste, düğümlerin birbirine bağlı olduğu, lineer bir veri yapısıdır.

## Dosya Yapısı

- `SinglyLinkedList.cs`: Tek yönlü bağlı listeyi temsil eden sınıf ve düğüm yapısı.
- `DoublyLinkedList.cs`: Çift yönlü bağlı listeyi temsil eden sınıf ve düğüm yapısı.
- `LinkedListEnumerator.cs`: Bağlı listeyi numaralandırmak için bir numaralandırıcı (enumerator) sınıfı.
- `Program.cs`: Uygulamanın ana giriş noktası.

## Kullanım

Örnek kullanım:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Tek yönlü bağlı liste örneği
        SinglyLinkedList<int> singlyList = new SinglyLinkedList<int>();
        
        singlyList.AddLast(1);
        singlyList.AddLast(2);
        singlyList.AddLast(3);
        
        Console.WriteLine("Tek Yönlü Bağlı Liste:");
        foreach (var item in singlyList)
        {
            Console.WriteLine(item);
        }

        // Çift yönlü bağlı liste örneği
        DoublyLinkedList<int> doublyList = new DoublyLinkedList<int>();
        
        doublyList.AddLast(1);
        doublyList.AddLast(2);
        doublyList.AddLast(3);
        
        Console.WriteLine("Çift Yönlü Bağlı Liste:");
        foreach (var item in doublyList)
        {
            Console.WriteLine(item);
        }
    }
}


## Özellikler

### Tek Yönlü Bağlı Liste

- **Başa ve Sona Eleman Ekleme:** Tek yönlü bağlı listede yeni elemanları listenin başına veya sonuna ekleyebilirsiniz.
- **Belirli Bir Indekse Eleman Ekleme:** Belirli bir indekse eleman ekleyebilirsiniz.
- **Belirli Bir Indeksteki Elemanı Kaldırma:** Belirli bir indeksteki elemanı kaldırabilirsiniz.
- **Liste Elemanlarını Dolaşma:** Tek yönlü bağlı listedeki elemanları döngü kullanarak dolaşabilirsiniz. Örneğin, `foreach` döngüsü kullanarak liste elemanlarını dolaşabilirsiniz.

### Çift Yönlü Bağlı Liste

- **Başa ve Sona Eleman Ekleme:** Çift yönlü bağlı listede yeni elemanları listenin başına veya sonuna ekleyebilirsiniz.
- **Belirli Bir Indekse Eleman Ekleme:** Belirli bir indekse eleman ekleyebilirsiniz.
- **Belirli Bir Indeksteki Elemanı Kaldırma:** Belirli bir indeksteki elemanı kaldırabilirsiniz.
- **Liste Elemanlarını Dolaşma:** Çift yönlü bağlı listedeki elemanları döngü kullanarak dolaşabilirsiniz. Örneğin, `foreach` döngüsü kullanarak liste elemanlarını dolaşabilirsiniz.

