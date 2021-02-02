using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Berk";
            //musteri1.Soyadi = "Üstünel";
            //musteri1.Id = 1;
            //musteri1.TcNo = "12345678901";
            //musteri1.VergiNo = "1234567890";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?"; 
            //gercek musteri - tüzel musteri
            //SOLID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Berk";
            musteri1.Soyadi = "Üstünel";
            musteri1.TcNo = "12345678901";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Berk Ecommerce";
            musteri2.MusteriNo = "123";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new TuzelMusteri(); //bir yerde new görüyorsak referans numarası aklımıza gelsin.
            Musteri musteri4 = new GercekMusteri(); //inheritance

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



            Console.WriteLine("Hello World!");
        }
    }
}
