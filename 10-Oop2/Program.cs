using _10_Oop2;

//Musteri musteri1 = new Musteri();
//musteri1.Adi = "Servan";
//musteri1.Soyadi = "Ayaz";
//musteri1.Id = 1;
//musteri1.TcNo = "222222222";
//musteri1.MusteriNo = "12345";
//musteri1.SirketAdi = "?";

//Gerçek Müşteri - Tüzel Müşteri
//solid

GercekMusteri gercekMusteri=new GercekMusteri();
gercekMusteri.Id = 1;
gercekMusteri.MusteriNo = "1232";
gercekMusteri.TcNo = "123456465";
gercekMusteri.Adi = "Servan";
gercekMusteri.Soyadi = "Ayaz";

TuzelMusteri tuzelMusteri = new TuzelMusteri();
tuzelMusteri.Id = 2;
tuzelMusteri.MusteriNo = "65465";
tuzelMusteri.SirketAdi = "Kodlama.IO";
tuzelMusteri.VergiNo = "235465";

//ikisinin de referansını tutabilir
Musteri musteri1 = new GercekMusteri();
Musteri musteri2 = new TuzelMusteri();

MusteriManager musteriManager1 = new MusteriManager();
musteriManager1.Ekle(gercekMusteri);
musteriManager1.Ekle(tuzelMusteri);
musteriManager1.Ekle(musteri1);
musteriManager1.Ekle(musteri2);
