﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtKrediManager = new IhtiyacKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();

            List<ILoggerService> logger = new List<ILoggerService> {new DataBaseLoggerService(), new FileBaseLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,logger);
            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasitKrediManager , konutKrediManager};

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
