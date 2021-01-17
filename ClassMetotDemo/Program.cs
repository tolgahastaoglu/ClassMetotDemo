using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            Console.WriteLine("1 Müşteri ekleme");
            Console.WriteLine("2 Müşteri Silme");
            int secim = Convert.ToInt32(Console.ReadLine());
            MusteriManager musterimanager = new MusteriManager();
            if (secim==1)
            {
                musterimanager.Ekle();
            }
            else if (secim == 2)
            {
                musterimanager.Sil();
            }
            else
            {
                Console.WriteLine("Doğru seçim yapınız");
            }
        }
    }
}
