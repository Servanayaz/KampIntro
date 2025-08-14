 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Oop2
{
    public class Musteri
    {
        //matematiksel işlem yapmıyorsan string tut tc vs gibi şeyleri
        //bir özellik bir nesneye ait gibi değilse orda hata vardır
        //hem tüzel hem gerçek kişi tutmaya çalışıyoruz -> örneğin şirket adı
        //burda soyutlamaya ihtiyaç var
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public string SirketAdi { get; set; }
        //public string TcNo { get; set; }
        //public string VergiNo { get; set; }
    }
}
