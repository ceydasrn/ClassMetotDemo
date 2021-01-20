using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static Musteri MusteriEkle(int id, string isim, string soyisim, int yas)
        {
            Musteri musteri = new Musteri();
            musteri.id = id;
            musteri.isim = isim;
            musteri.soyisim = soyisim;
            musteri.yas = yas;

            return musteri;
        }
        public static void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşterinin adı: " + musteri.isim);
            Console.WriteLine("Müşterinin soyadı: " + musteri.soyisim);
            Console.WriteLine("Müşterinin yaşı: " + musteri.yas);
            Console.WriteLine("-----------------------------------");
        }
    }
}
