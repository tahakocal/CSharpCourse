using System;
using System.Threading.Channels;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type Safety
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;


            ///////
            double dolarDun = 7.36;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }
            

        

            //////
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("Sisteme giris yapilmis");
            }
            else
            {
                Console.WriteLine("Sisteme giris yapin!");
            }

            // DO NOT REPEAT YOURSELF !!!

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
