using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Interface lerde implement edilen classların referans bilgilerini tutabilir.
            //O yüzden ICreditManager olarak değiştirdik.

            //NeedCreditManager needCreditManager = new NeedCreditManager();
            ICreditManager needCreditManager = new NeedCreditManager();
        
            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            
            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(needCreditManager, fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager> { needCreditManager, vehicleCreditManager };
            

            //applicationManager.MakeInitialCreditInfo(credits);

            //DatabaseLoggerService.MakeInitialCreditInfo(credits);
        }
    }
}
