using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static System.Collections.Specialized.BitVector32;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<string> list = new List<string>();
list.Add("Servan");

//dizi gibi belli sınırı yok ekleme silme daha kolay
List<string> list2 = new List<string> { "Melisa", "Özgür", "Deniz","Mehmet" };
Console.WriteLine(list2[0]);
Console.WriteLine(list2[1]);
Console.WriteLine(list2[2]);
Console.WriteLine(list2[3]);
list2.Add("Ayşe");
Console.WriteLine(list2[4]);

foreach (string isim in list2)
{
    Console.WriteLine(isim);
}

//1. Ekleme ve Silme
//| Metot | Açıklama | Örnek |
//| -------------------------------- | ------------------------------------------ | ---------------------------------- |
//| `Add(item)`                      | Liste sonuna eleman ekler.                 | `liste.Add(10);`                   |
//| `AddRange(collection)`           | Başka koleksiyondaki tüm elemanları ekler. | `liste.AddRange(yeniListe);`       |
//| `Insert(index, item)`            | Belirtilen konuma eleman ekler.            | `liste.Insert(1, 50);`             |
//| `InsertRange(index, collection)` | Belirtilen konuma koleksiyon ekler.        | `liste.InsertRange(2, yeniListe);` |
//| `Remove(item)`                   | İlk bulduğu elemanı siler.                 | `liste.Remove(10);`                |
//| `RemoveAt(index)`                | Belirtilen indisteki elemanı siler.        | `liste.RemoveAt(0);`               |
//| `RemoveRange(index, count)`      | Belirtilen aralıktaki elemanları siler.    | `liste.RemoveRange(1, 2);`         |
//| `Clear()`                        | Tüm elemanları siler.                      | `liste.Clear();`                   |

// 2. Arama
//| Metot | Açıklama | Örnek |
//| -------------------- | --------------------------- | ---------------------------- |
//| `Contains(item)`     | Eleman var mı kontrol eder. | `liste.Contains(20)`         |
//| `IndexOf(item)`      | İlk bulunduğu indeks        | `liste.IndexOf(20)`          |
//| `LastIndexOf(item)`  | Son bulunduğu indeks        | `liste.LastIndexOf(20)`      |
//| `Find(predicate)`    | Şarta uyan ilk eleman       | `liste.Find(x => x > 50)`    |
//| `FindAll(predicate)` | Şarta uyan tüm elemanlar    | `liste.FindAll(x => x > 50)` |
//| `Exists(predicate)`  | Şarta uyan eleman var mı?   | `liste.Exists(x => x < 0)`   |

//3.Sıralama ve Düzenleme
//| Metot | Açıklama | Örnek |
//| -------------------------------- | --------------------------------- | ------------------------------------- |
//| `Sort()`                         | Küçükten büyüğe sıralar           | `liste.Sort();`                       |
//| `Reverse()`                      | Elemanların sırasını ters çevirir | `liste.Reverse();`                    |
//| `OrderBy` / `OrderByDescending`  | LINQ ile sıralama                 | `liste.OrderBy(x => x)`               |
//| `ConvertAll<TOutput>(converter)` | Tüm elemanları dönüştürür         | `liste.ConvertAll(x => x.ToString())` |

//4. Diğer
//| Metot / Özellik | Açıklama | Örnek |
//| ----------------- | --------------------------- | ------------------------------------------- |
//| `Count`           | Eleman sayısı               | `int adet = liste.Count;`                   |
//| `Capacity`        | Ayrılan kapasite            | `liste.Capacity`                            |
//| `ToArray()`       | Listeyi diziye çevirir      | `int[] dizi = liste.ToArray();`             |
//| `ForEach(action)` | Her eleman için işlem yapar | `liste.ForEach(x => Console.WriteLine(x));` |


//----------------LİNQ ile-----------------

// 1. Filtreleme
//| Metot | Açıklama | Örnek |
//| ---------------------------- | --------------------------------------------------- | --------------------------------------- |
//| `Where(predicate)`           | Şarta uyan elemanları döndürür                      | `sayilar.Where(x => x > 50)`            |
//| `First(predicate)`           | Şarta uyan ilk elemanı döndürür (bulamazsa hata)    | `sayilar.First(x => x > 50)`            |
//| `FirstOrDefault(predicate)`  | Şarta uyan ilk elemanı döndürür (bulamazsa default) | `sayilar.FirstOrDefault(x => x > 50)`   |
//| `Single(predicate)`          | Tek bir eleman bekler, yoksa veya fazla varsa hata  | `sayilar.Single(x => x == 20)`          |
//| `SingleOrDefault(predicate)` | Tek eleman ya da default döner                      | `sayilar.SingleOrDefault(x => x == 20)` |

// 2. Sıralama
//| Metot | Açıklama | Örnek |
//| -------------------------------- | ---------------------------------------- | ------------------------------------------------------- |
//| `OrderBy(keySelector)`           | Artan sırada sıralar                     | `sayilar.OrderBy(x => x)`                               |
//| `OrderByDescending(keySelector)` | Azalan sırada sıralar                    | `sayilar.OrderByDescending(x => x)`                     |
//| `ThenBy(keySelector)`            | İkinci bir artan sıralama kriteri ekler  | `liste.OrderBy(x => x.Yas).ThenBy(x => x.Ad)`           |
//| `ThenByDescending(keySelector)`  | İkinci bir azalan sıralama kriteri ekler | `liste.OrderBy(x => x.Yas).ThenByDescending(x => x.Ad)` |

//3. Seçim ve Dönüştürme
//| Metot | Açıklama | Örnek |
//| ---------------------- | ------------------------------------------- | ---------------------------------- |
//| `Select(selector)`     | Elemanları başka bir tipe/diziye dönüştürür | `sayilar.Select(x => x * 2)`       |
//| `SelectMany(selector)` | İç içe koleksiyonları düzleştirir           | `liste.SelectMany(x => x.Dersler)` |
//| `Distinct()`           | Tekrar edenleri çıkarır                     | `sayilar.Distinct()`               |

//4. Gruplama
//| Metot | Açıklama | Örnek |
//| ---------------------- | -------------------------------- | --------------------------------------------------- |
//| `GroupBy(keySelector)` | Elemanları anahtara göre gruplar | `sayilar.GroupBy(x => x % 2 == 0 ? "Çift" : "Tek")` |

//5. Toplama / Sayma
//| Metot | Açıklama | Örnek |
//| ------------------ | ----------------------------------- | ---------------------------- |
//| `Count()`          | Eleman sayısını döndürür            | `sayilar.Count()`            |
//| `Count(predicate)` | Şarta uyan eleman sayısını döndürür | `sayilar.Count(x => x > 50)` |
//| `Sum()`            | Toplam döndürür                     | `sayilar.Sum()`              |
//| `Average()`        | Ortalama döndürür                   | `sayilar.Average()`          |
//| `Min()` / `Max()`  | Minimum / maksimum değer döndürür   | `sayilar.Min()`              |

//6. İlk N / Son N Eleman
//| Metot | Açıklama | Örnek |
//| ---------------------- | -------------------------------------- | -------------------------------- |
//| `Take(n)`              | İlk n elemanı döndürür                 | `sayilar.Take(3)`                |
//| `TakeWhile(predicate)` | Şart sağlandığı sürece eleman döndürür | `sayilar.TakeWhile(x => x < 50)` |
//| `Skip(n)`              | İlk n elemanı atlar                    | `sayilar.Skip(2)`                |
//| `SkipWhile(predicate)` | Şart sağlandığı sürece eleman atlar    | `sayilar.SkipWhile(x => x < 50)` |

//-----örnek------
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    // Person sınıfı
//    class Person
//    {
//        public string Ad { get; set; }
//        public int Yas { get; set; }
//        public string Sehir { get; set; }
//    }

//    static void Main()
//    {
//        // Nesne listesi
//        List<Person> kisiler = new List<Person>
//        {
//            new Person { Ad = "Ali",    Yas = 25, Sehir = "İstanbul" },
//            new Person { Ad = "Ayşe",   Yas = 30, Sehir = "Ankara" },
//            new Person { Ad = "Mehmet", Yas = 20, Sehir = "İstanbul" },
//            new Person { Ad = "Fatma",  Yas = 28, Sehir = "İzmir" },
//            new Person { Ad = "Veli",   Yas = 35, Sehir = "Ankara" }
//        };

//        // 1️⃣ Yaşı 25'ten büyük olanlar
//        var buyukler = kisiler.Where(k => k.Yas > 25);
//        Console.WriteLine("Yaşı 25'ten büyükler:");
//        foreach (var k in buyukler)
//            Console.WriteLine($"{k.Ad} - {k.Yas} - {k.Sehir}");

//        // 2️⃣ İsme göre (A-Z) sıralama
//        var sirali = kisiler.OrderBy(k => k.Ad);
//        Console.WriteLine("\nİsme göre sıralama:");
//        foreach (var k in sirali)
//            Console.WriteLine($"{k.Ad} - {k.Yas} - {k.Sehir}");

//        // 3️⃣ Şehire göre gruplama
//        var gruplar = kisiler.GroupBy(k => k.Sehir);
//        Console.WriteLine("\nŞehire göre gruplama:");
//        foreach (var grup in gruplar)
//        {
//            Console.WriteLine($"Şehir: {grup.Key}");
//            foreach (var k in grup)
//                Console.WriteLine($"   {k.Ad} - {k.Yas}");
//        }

//        // 4️⃣ Sadece ad ve şehir bilgilerini seçme
//        var adVeSehir = kisiler.Select(k => new { k.Ad, k.Sehir });
//        Console.WriteLine("\nAd ve şehir bilgileri:");
//        foreach (var item in adVeSehir)
//            Console.WriteLine($"{item.Ad} - {item.Sehir}");
//    }
//}



