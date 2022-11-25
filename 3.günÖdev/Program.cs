using System;

namespace _3.günÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.adi = "yusuf";
            musteri1.meslek = "inşaat";
            musteri1.tc = "10023215632";
            musteri1.yas = 40;
            musteri1.maas = 10000;

            Musteri musteri2 = new Musteri();
            musteri2.adi = "seref";
            musteri2.meslek = "öğrenci";
            musteri2.tc = "10865223645";
            musteri2.yas = 18;
            musteri2.maas = 0;

            Musteri musteri3 = new Musteri();
            musteri3.adi = "arda";
            musteri3.meslek = "balıkcı";
            musteri3.tc = "10886223645";
            musteri3.yas = 25;
            musteri3.maas = 9000;

            Musteri[] musteriList = new Musteri[3]
            { musteri1,musteri2,musteri3};

            MusteriManager müsteriIslem = new MusteriManager();

            müsteriIslem.Listele(musteri1);
            Console.WriteLine("--------------");
            müsteriIslem.Listele(musteri2);
            Console.WriteLine("--------------");
            müsteriIslem.Listele(musteri3);
            Console.WriteLine("--------------");

            müsteriIslem.Ekle(musteri1);
            müsteriIslem.Ekle(musteri2);
            müsteriIslem.Ekle(musteri3);
            Console.WriteLine("--------------");
            müsteriIslem.Sil(musteri1);
            müsteriIslem.Sil(musteri2);
            müsteriIslem.Sil(musteri3);

        }
    }
}
