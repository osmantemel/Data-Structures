# Bağlı Liste (Linked List) Implementasyonu ve Stack Yapısı

Bu proje, C# programlama dili kullanılarak çift yönlü ve tek yönlü bağlı liste ve stack veri yapılarının  implementasyonunu içermektedir.


## Dosya Yapısı

- `SinglyLinkedList.cs`: Tek yönlü bağlı listeyi temsil eden sınıf ve düğüm yapısı.
- `DoublyLinkedList.cs`: Çift yönlü bağlı listeyi temsil eden sınıf ve düğüm yapısı.
- `LinkedListEnumerator.cs`: Bağlı listeyi numaralandırmak için bir numaralandırıcı (enumerator) sınıfı.
- `Stack`: Stack yapısı için sınıfların bulunduğu dosya
- `Program.cs`: Uygulamanın ana giriş noktası.


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

### Stack

Bu bölümde, bağlı liste veri yapısını kullanarak yığın (stack) veri yapısının bir implementasyonu bulunmaktadır.

- `ArrayStack.cs`: Dizi tabanlı stack implementasyonunu içeren sınıf.
- `LinkedListStack.cs`: Bağlı liste tabanlı stack implementasyonunu içeren sınıf.

Her iki sınıf da `IStack<T>` arayüzünü uygulamaktadır ve aşağıdaki temel operasyonları desteklemektedir:

- **Push:** Yığına yeni bir öğe ekler.
- **Pop:** Yığının en üstündeki öğeyi kaldırır ve döndürür.
- **Peek:** Yığının en üstündeki öğeyi döndürür ancak kaldırmaz.
- **Clear:** Yığındaki tüm öğeleri temizler.

Stack yapısının kullanımı ve avantajları hakkında daha fazla bilgi için lütfen belirtilen sınıfları inceleyin.



