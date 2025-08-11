using _7_OOP1;

Product product1= new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Table";
product1.UnitsInStock = 3;
product1.UnitPrice = 1500;

Product product2= new Product { Id=2,CategoryId=3,UnitsInStock=5,ProductName="Pencil",UnitPrice=45};

//yorumlar referans ve değer tipler için güzel örnek BirSeyYap metodunu ve Add metodundaki yorumları da aç
//case sensetive
//PascalcCase  //camelCase
//ProductManager productManager = new ProductManager();
//productManager.Add(product1);//referansı 101 olsun
//Console.WriteLine(product1.ProductName);
//atamalar referans numarasıyla yapılınca direk bellek adresi üzerinden gider
//metotta yapılan değişiklik ise direk bellekteki veriyi değiştirir
//okuduğunda ise artık ordaki yeni veriyi okursun

//int sayi = 100;
//productManager.BirSeyYap(sayi);
//Console.WriteLine(sayi); //100
//burdaki sayi 100 metota öyle yolladık
//metotta ise gidip metodun parametresindeki sadece ismi benzeyen sayiyi 99 yaptı
//burdaki sayıyla alakası yok

//product için kamera döndü metotta geçtiğimiz
//sayı için ise 100 döndü oysa metotta 99 geçmiştik
//int, double, bool... -> değer tip
//dizi, class. abstract class, interface... -> referans tip

ProductManager productManager1 = new ProductManager();
productManager1.Update(product1);

//gelen değeri kullanabilirsin sana int tipinde bir şey verir
productManager1.ToplaReturn(3, 6);
//yazdırmaz ama yazdırmak için
Console.WriteLine(productManager1.ToplaReturn(3, 6));
int toplam = productManager1.ToplaReturn(5,4);
Console.WriteLine(toplam*5);

//gelen değeri kullanamazsın
productManager1.ToplaVoid(3, 6);
//hata verir
//int toplam2= productManager1.ToplaVoid(5,6);


