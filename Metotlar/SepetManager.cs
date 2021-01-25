using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. " + urun.Adi +  " sepete eklendi!");
        }

        //bu kullanım da doğru ancak böyle metot yazılmaması lazım. Yarın bir gün tekrar başka bir veri tipi
        //eklenebilir. Metotu değiştirmemiz gerekiyor tüm sayfalarda
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. " + urunAdi + " sepete eklendi!");
        }

    }
}
