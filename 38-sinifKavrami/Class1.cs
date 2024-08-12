
namespace _38_sinifKavrami
{
    internal class Personel

    {
        // Bir sınıfın içinde fields, proporties, metot yer alabilir. Sınıf üyeleri( class members);

        // Property (özellik)

        // Property ' i oluşturmak için prop yazıp iki kere tab tuşuna basarız

        // propfull tab tab

        public string ad { get; set; }

        private string _soyad; // private sınıf içinden erişileblir

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value.ToUpper(); }
        }


        public int yas { get; set; }

        public string unvan { get; set; }

        public decimal maas { get; set; }

        public decimal tabanMaas { get; set; }

        public int cocukSayisi { get; set; }


        public void MaasHesapla()
        {
            if(cocukSayisi==0)
            {
                maas = tabanMaas;

            }
            else if (cocukSayisi<3)
            
                maas = tabanMaas * 1.05m; //maaşının %5i kadar
            

            else if(cocukSayisi>=3)
            
                maas = tabanMaas * 1.10m;
            
        }

        public void PersonelBilgileriniYaz()
        {
            MaasHesapla();

            Console.WriteLine($"Adı: {ad}\n Soyad: {Soyad}\n Yaşı : {yas}\n unvan: {unvan}\n Maaşı: {maas}");
        }

    }
}
