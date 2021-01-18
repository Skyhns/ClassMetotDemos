using System;

namespace ClassMetotDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Samet";
            musteri1.musteriSoyadi = "Kayahan";
            musteri1.Id = 1234567890;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Engin";
            musteri2.musteriSoyadi = "Aydın";
            musteri2.Id = 123456789;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri a in musteriler)
            {
                Console.WriteLine("Müşteri Adi : " + a.musteriAdi);
                Console.WriteLine("Müşteri Soyadi : " + a.musteriSoyadi);
                Console.WriteLine("Müşteri ID : " + a.Id);

                Console.WriteLine("------------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("------------------------------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            Console.WriteLine("------------------------------------------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);



        }


    }
}
