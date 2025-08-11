using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager // sepet işlemleri
    {
        //manager, service, dal -> operasyon tutan sınıflar
        public void Ekle(Urun urun)
        {
            //stok adedinden önceki yazımı
            //Console.WriteLine(urun.Adi + " sepete eklendi.");
            //stok adedi eklenince olan kod
            Console.WriteLine(urun.Adi + " sepete eklendi.Kalan stok adedi : "+(urun.StokAdedi-1));
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat) 
        {
            Console.WriteLine(urunAdi + " sepete eklendi.");
        }
    }
}
