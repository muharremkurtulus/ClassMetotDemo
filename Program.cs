using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler();
            musteri1.Id = "1101";
            musteri1.Adi = "Muharrem";
            musteri1.Soyadi = "Kurtuluş";
            musteri1.Mesleği = "Yazılım Geliştirici";


            Musteriler musteri2 = new Musteriler();
            musteri2.Id = "1102";
            musteri2.Adi = "İrem";
            musteri2.Soyadi = "Gülmüş";
            musteri2.Mesleği = "IK Müdürü";


            Musteriler musteri3 = new Musteriler();
            musteri3.Id = "1103";
            musteri3.Adi = "Cem";
            musteri3.Soyadi = "Taylan";
            musteri3.Mesleği = "Lojistik";


            Musteriler musteri4 = new Musteriler();
            musteri4.Id = "1104";
            musteri4.Adi = "Gülcan";
            musteri4.Soyadi = "Demiral";
            musteri4.Mesleği = "Devlet Memuru";


            Musteriler[] musteri = new Musteriler[] {musteri1,musteri2,musteri3,musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("*****Müşteri Ekleme Metotu*****");
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("*****Müşteri Silme Metotu*****");
            musteriManager.MusteriSil(musteri3);
            Console.WriteLine("*****Müşteri Listeleme Metotu******");
            musteriManager.MusteriListele(musteri);








        }
    }
}
