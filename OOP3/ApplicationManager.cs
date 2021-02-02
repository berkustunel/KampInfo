using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //method injection
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //
            creditManager.Hesapla();
            loggerService.Log();
        }

        public void MakeInitialCreditInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
            
        }
    }
}
