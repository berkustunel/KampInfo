using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elmasi";


            //string urunadi = "çilek";
            //double fiyati = 10;
            //string aciklama = "çilek gibi çilek";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            //type-safe --tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("---------------Metotlar---------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("--------------- Hatali Metot Kullanimi---------------");
            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80);



        }
    }
}

//tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
//DONOT REPEAT YOURSELF - DRY - Clean Code - Best Practice