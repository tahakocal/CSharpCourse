using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[]
            {
                "Yazilim Gelistirme Yetistirme Kampi" , "Programlamaya Baslangic Icin Temel Kurs", "Java","C++" , "Python"
            };



            for (int i = 0; i < kurslar.Length; i++) // i++) yerine i=i+2 yapabiliriz o zaman 2 2 artar
                  // yazdigimizin uzunlugu kadar yaziyor
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");


            foreach (string kurs in kurslar)  // kurslari dolas dedik // kurs olarak isimlendirdigimiz olay aslinda ALIAS
            {
                Console.WriteLine(kurs);   
            }

            Console.WriteLine("Sayfa Sonu "); 
        }
    }
}
