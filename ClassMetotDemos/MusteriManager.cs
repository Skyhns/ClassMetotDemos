using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemos
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi! : " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.Id);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi! : " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.Id);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Silindi! : " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.Id);
        }
    }   
       
}
