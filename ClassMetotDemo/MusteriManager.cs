using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle()
        {
            Musteri ekle = new Musteri();
            ekle.Id = 5;
            Console.Write("Yeni Müşteri Adı Giriniz: ");
            ekle.Adi = Console.ReadLine();
            Console.Write("Yeni Müşteri Soyadı Giriniz: ");
            ekle.Soyadii = Console.ReadLine();
            Console.WriteLine("Yeni Müşteri Eklenmiştir");
        }
        public void Sil()
        {
            Console.Write("Silinecek Müşteri ID giriniz: ");
            
           
        }


    }
}
