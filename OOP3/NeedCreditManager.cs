using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //ihtiyaç kredisi
    class NeedCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyac kredisi ödeme planı hesaplandı");
        }
    }
}
