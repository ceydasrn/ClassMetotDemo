using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = MusteriManager.MusteriEkle(1, "Ceyda", "Saran", 21);
            Musteri musteri2 = MusteriManager.MusteriEkle(2, "Baran", "Taşçı", 26);
            Musteri musteri3 = MusteriManager.MusteriEkle(3, "Burak", "Yılmaz", 23);
            Musteri musteri4 = MusteriManager.MusteriEkle(4, "Ali", "Şahin", 19);

            MusteriManager.MusteriListele(musteri1);
            MusteriManager.MusteriListele(musteri2);
            MusteriManager.MusteriListele(musteri3);
            MusteriManager.MusteriListele(musteri4);
            

        }
    }
}
