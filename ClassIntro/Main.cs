using ClassIntro;

Kurs kurs1=new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 99;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Şervan Ayaz";
kurs2.IzlenmeOrani = 90;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Pyhton";
kurs3.Egitmen = "Melisa Alımterin";
kurs3.IzlenmeOrani = 100;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
}