//string kurs1 = "Yazılım Geliştirme Kampı";
//string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
//string kurs3 = "C#";

//diziye at ve döngü kullan ki dinamik olsun

//array - dizi

//for (int i = 1; i <= 10; i+=2)
//{
//    Console.WriteLine(i);
//}

string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "C#","Java" };

for (int i = 0; i <kurslar.Length; i ++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("*************");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine();