//1. Değer Tip (Value Type) — int, double, bool, decimal, float gibi bellekte değeri saklar (kopyalar)
//değşiklik sonrasında diğerini etkilemez
//stackte tutulur
//sayi1=sayi2 dediğinde artık sayi1 in ilk değeri kaybolur çöp toplayıcı toplar
//sayi2=65 dersen de aynı işlem bağlantı kopar eski değerle

int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
Console.WriteLine(sayi1);

//2. Referans Tip (Reference Type) — array, class, string, interface gibi bellekte referans saklar (paylaşır)
//bellek adresi değişiklik iki tarafta da görülür
//sadece birini etkilesin istersen clone veya copy ile kopyala diziyi eşitleme
//int[] sayilar1 dediğin an stackte yer ayırır
//new dediğin anda heap te yer oluşturur ve verilerini oraya ekler 
//sayilar1 heapteki adresini tutar
//sayilar1=sayilar2 dersen artık sayilar1 heapteki sayilar2 nin adresini(referansını tutar)
//kendi yeriyle olan referansı kopar çöp toplayıcı onu bellekten ataar
//artık birinde değişiklik yaparsan ikisinde de değişir
int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };

sayilar1= sayilar2;
sayilar2[0] = 9999;

foreach (int i in sayilar1)
{
    Console.WriteLine(i);
}


