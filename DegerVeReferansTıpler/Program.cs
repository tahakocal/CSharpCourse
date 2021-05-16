using System;

namespace DegerVeReferansTıpler
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEGER TIP
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65; // https://prnt.sc/11pcejb COK IYI ORNEK KONUYU ANLATIYOR

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            //REFERANS TIP 
            int[] sayilar1 = new int[] { 10, 20, 30 };     // https://prnt.sc/11pd4s8 KONUYU YINE IYI BIR SEKILDE ANLATIYOR
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);
            Console.WriteLine(sayilar2[0]);
        }
    }
}
