using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        public void Add(Product product) // product product yazdi[imiz icin product add i cagirabiliyoruz
        {
            Console.WriteLine("Urun Eklendi! : " + product.Adi);
        }

        public void Ekle2  (string Adi, string Aciklama, double fiyat)
        {
            Console.WriteLine("Urun Eklendi! : " + Adi);
        }

    }
}
