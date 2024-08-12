


// Instance alma (örnek alma)

//new Random();

// Perspnel sınıfından bir nesne (örnek) (nesne) (instance) oluşturdum.

using _38_sinifKavrami;

Personel calisan1 = new Personel(); // Personel veri tipindeki çalışan değişkeni Personel nesnesini tutuyır

calisan1.ad = "Tuğba";
calisan1.Soyad = "Yaz";
calisan1.yas = 25;
calisan1.unvan = "Yazılım Uzmanı";

Console.WriteLine("Personel Bilgileri");
Console.WriteLine($"Adı: {calisan1.ad}\nSoyad: {calisan1.Soyad}\nYaşı: {calisan1.yas}\n Unvanı: {calisan1.unvan}");

//////////////////////////////////////
Console.WriteLine(new string('*', 40));

Personel calisan2 = new Personel();

//calisan2.ad = "Bilge";
//calisan2.Soyad = "Adam";
//calisan2.yas = 30;
//calisan2.unvan = "Yazılımcı";

//Console.WriteLine("Personel Bilgileri");

calisan2.PersonelBilgileriniYaz();


// NOt: Erişim belirteci private olan bir fielda dışardan erişemeyiz.İçerisine veri atamak veya veri okumak i.in propertyleri kullanırız.