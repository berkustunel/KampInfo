using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //arrayin lengthini genişletmek için önce tempArrayde tutuyoruz mevcut değerleri.
            items = new T[items.Length+1]; //genişlettik lengti ve tempte kaldı tüm değerlerimiz. Lenght genişlediği için içindeki değerler silindi.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //genişlettikten sonra tempte kalan değerleri asıl arrayimize tekrar koyuyoruz
            }

            items[items.Length - 1] = item; //en sonunda da eklediğimiz item'ı en son sıraya yerleştiriyoruz.
        }
    }
}
