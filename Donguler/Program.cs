using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç için Temel Kurs", "Java" , 
                "Python" , "C#" };

            int length = 3;
            for (int i = 0; i < kurslar.Length; i++) //i = i+2
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For loop bitti");
            foreach (string kurs in kurslar) //Diziyi tek tek dolaş
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
