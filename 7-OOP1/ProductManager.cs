using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP1
{
    public class ProductManager //operasyon sınıfı
    {
        //CRUD
        public void Add(Product product)
        {
            //product.ProductName = "Kamera";//referansı 101 olandaki veriyi değiştirdi ve kamera yaptı
            Console.WriteLine(product.ProductName + " added");
        }

        //public void BirSeyYap(int sayi)
        //{
        //    sayi = 99;
        //}

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated");
        }


        //burası ise değer döndürür sonuçla işimiz varsa kullan
        public int ToplaReturn(int a,int b)
        {
            return a + b;
        }

        //void emir verir işlem yapar sil güncelle vs
        //işlem sonucuyla ilgimiz yoksa kullanılır değer dönürmez
        //sonucu bir yerde tutmaz işlemi yapar sadece
        public void ToplaVoid(int a, int b)
        {
            Console.WriteLine(a + b); 
        }
    }
}
