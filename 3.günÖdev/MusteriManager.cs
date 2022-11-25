using System;
using System.Collections.Generic;
using System.Text;

namespace _3.günÖdev
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.adi + "  Müşteri eklendi");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri T.C : "+musteri.tc);
            Console.WriteLine("Müşteri Adı : "+musteri.adi);
            Console.WriteLine("Müşteri Yaşı : "+musteri.yas);
            Console.WriteLine("Müşteri Mesleği : "+musteri.meslek);
            Console.WriteLine("Müşteri Maaşı : "+musteri.maas);


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.adi+" Müşteri Silindi");
        }
    }
}
