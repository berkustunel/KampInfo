using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Berk";
            int yas = 26;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Berk Üstünel";
            kurs1.IzlenmeOrani = 66;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ali Veli";
            kurs2.IzlenmeOrani = 27;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ahmet Mehmet";
            kurs3.IzlenmeOrani = 48;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ayşe Fatma";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar) //kursların hepsini yazmak için gerekli. tek tek yazmak yerine.
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
