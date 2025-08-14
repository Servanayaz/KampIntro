using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Oop2
{
    //iş sınıfları // business classes
    public class MusteriManager
    {
        public void Ekle(Musteri musteri) // basesınıftan ilerlediğimiz için birden fazlasını gönderebiliriz
                                          // pollymorphism
        {
             if (musteri.Id == null)
             {
                Console.WriteLine("İd boş olamaz");
             }
             else
             {
                Console.WriteLine("Eklendi : "+musteri.Id);
             }
        }
    }
}
