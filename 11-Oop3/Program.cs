using _11_Oop3;

IhtiyacKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

//interfaceler de onu implemente eden classların referansını tutabilir
IKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

IKrediManager konutKrediManager= new KonutKrediManager();
//konutKrediManager.Hesapla();

BasvuruManager basvuruManager=new BasvuruManager();
//basvuruManager.BasvuruYap(ihtiyacKrediManager);
//basvuruManager.BasvuruYap(tasitKrediManager);
//basvuruManager.BasvuruYap(konutKrediManager);


//loggerservice yazdıktan sonra burayı güncelledik
ILoggerService fileLoggerService =new FileLoggerService();

basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService()); //farklı kullanımı
basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);
basvuruManager.BasvuruYap(konutKrediManager, new FileLoggerService());

List<IKrediManager> krediManagers=new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);

//burası kredi ön bilgilendirmenin de liste olarak loglanması
//istediğimiz birden çok yere loglamamızı sağladı
var krediler = new List<IKrediManager>
{
    new KonutKrediManager(),
    new IhtiyacKrediManager()
};

var loglar = new List<ILoggerService>
{
    new FileLoggerService(),
    new DatabaseLoggerService()
};

BasvuruManager basvuruManager2 = new BasvuruManager();
basvuruManager.KrediOnBilgilendirmesiYap2(krediler, loglar);

//burası başvurunun da liste olarak loglanması
//istediğimiz birden çok yere loglamamızı sağladı
BasvuruManager basvuruManager1 = new BasvuruManager();
basvuruManager1.BasvuruYap2(new IhtiyacKrediManager(), loglar);

