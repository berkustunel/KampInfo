using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //alternatif kullanım
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase    //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //sonuç Kamera

            int sayi = 100;
            productManager.Test(sayi);
            Console.WriteLine(sayi); //sonuç 100, 99 değil

            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla1(3, 6);
            Console.WriteLine("Toplama sonucu : " + toplamaSonucu*2); 
            //return kullanırsam yani int'li bir method olursa üzerine işlem yapabiliriz.
            //void'li methotlarda bunu yapamıyoruz. Return kullanmamız gerekiyor.



            //int,double,bool... değer tip
            //diziler,class, abstarct class, interface... referans tip
            //ref out

        }
    }
}
