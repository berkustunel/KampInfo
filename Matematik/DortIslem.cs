using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //Topla(2,3)
        public void Topla(int x, int y)
        {
            int toplam = x + y;
            Console.WriteLine("Sonuc : " + toplam);
        }

        public void Cikar(int x, int y)
        {
            int cikarma = x - y;
            Console.WriteLine("Sonuc : " + cikarma);
        }

        public void Carp(int x, int y)
        {
            int carpma = x * y;
            Console.WriteLine("Sonuc : " + carpma);
        }

        public void Bol(double x, double y)
        {
            double bolme = x / y;
            Console.WriteLine("Sonuc : " + bolme);
        }
    }
}
