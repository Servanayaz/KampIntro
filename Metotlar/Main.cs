// metotlar tekrar tekrar kullanılabilirlik sağlar - dont repeat yourself (dry)
//clean code
//best practice - doğru uygulama teknikleri

using Metotlar;

Urun urun1=new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";
//stok adedi ekleyelim
urun1.StokAdedi = 15;

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";
//stok adedi ekleyelim
urun2.StokAdedi=15;

Urun[] urunler = new Urun[] {urun1,urun2};

//type-safe  -  tip güvenli
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi + "\n Fiyat : "+urun.Fiyati + "\n Açıklama : "+urun.Aciklama);
}
Console.WriteLine();

Console.WriteLine("--------Metotlar----------");

//encapsulation - ayrı ayrı atllatki gibi yazacağını böyle yazıp kapsülleme
// instance - örnek
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

//bu şekilde yazarsan üstteki yerine stok adedi de eklenirse özelliğe her yeri 100 diyelim hepsini değiştirmen lazım
//üstteki gibi yazarsan classa bir property eklersin stok adedi diye metoda geçersin ve yüzlerce değişir
sepetManager.Ekle2("Armut", "Yeşil armut", 12);
sepetManager.Ekle2("Elma", "Yeşil elma", 15);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 21);

