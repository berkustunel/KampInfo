using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation

        //void methodları --> işlemi yapııyor ve bitiriyor. İşlem sonucunda ekstra bilgiye ihtiyaç yok
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
            
            //product.ProductName = "Kamera";
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla1(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        public void Test(int sayi)
        {
            sayi = 99;
        }


    }
}
