//type safety - tip güvenliği
string kategoriEtiketi = "Kategori";
Console.WriteLine(kategoriEtiketi);
//değiken amacı tek değişken değişirse tüm yerlerde değişmesini sağlarız
//kendimizi tekrarlamadan kurtarmayı sağlar

int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi=false;
double dolarDun = 7.35;
double dolarBugun = 7.45;
if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış");
}
else if (dolarBugun > dolarDun) 
{
    Console.WriteLine("Artış");
}
else
{
    Console.WriteLine("Değişmedi");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}