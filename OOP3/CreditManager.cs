using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager //okuma rahat olsun diye interface'de I ile başlıyoruz.
        //interfaceleri genellikle operasyonel class larda kullanıyoruz. Arayüz. 
        //100lerce kredi var. Hepsini class içinde yönetemiyoruz. O yüzden interface kullanıyoruz.
        //Interfaceleri birbirlerinin alternatifi olan ama kod içeriği farklı olan şeyler için kullanıyoruz.
    {

        void Hesapla();
        void BiseyYap();

    }
}
