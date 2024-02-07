using System;
namespace ClassMetotDemo
{
	public class MusteriManager
	{
		public void MusteriEkle(Musteriler musteri)
		{
			Console.WriteLine("Tebrikler " + musteri.Adi + " " + musteri.Soyadi +" isimli müşteri eklendi.");
		}

        public void MusteriSil(Musteriler musteri)
        {
            Console.WriteLine("Tebrikler " + musteri.Adi + " " +musteri.Soyadi + " isimli müşteri silindi.");
        }

        public void MusteriListele(Musteriler[] musteri)
        {
            foreach (var Musteriler in musteri)
            {
                Console.WriteLine("Müşteri ID : " + Musteriler.Id);
                Console.WriteLine("Müşteri Adı : " + Musteriler.Adi);
                Console.WriteLine("Müşteri Soyadı : " + Musteriler.Soyadi);
                Console.WriteLine("Müşteri Mesleği : " + Musteriler.Mesleği);
                Console.WriteLine("------");

            }

        }

    }
}

