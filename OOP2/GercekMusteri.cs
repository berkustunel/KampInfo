using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance - miras
    class GercekMusteri : Musteri //ebeveyn - parent
    {

        public string TcNo { get; set; } //neden int degil cünkü TCKN ve VKNde hesaplama yapmıyoruz. Metinsel olarak tutulmalıdır.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
