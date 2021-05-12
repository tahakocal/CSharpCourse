using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           // IKrediManager tasitKrediManager = new TasitKrediManager();
           // IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasitKrediManager , konutKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
