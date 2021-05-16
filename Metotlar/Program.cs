using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product products1 = new Product();
            products1.Id = 1;
            products1.Adi = "Elma";
            products1.Fiyati = 5;
            products1.Aciklama = "Amasya Elmasi";

            Product products2 = new Product();
            products2.Id = 2;
            products2.Adi = "Karpuz";
            products2.Fiyati = 85;
            products2.Aciklama = "Diyarbakir Karpuzu";


            Product[] products = new Product[] { products1, products2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------------------------");

            }

            Console.WriteLine("--------------------Metotlar--------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(products1);
            sepetManager.Add(products2);


            sepetManager.Ekle2("Armut", "Yesil Armut", 29);
            sepetManager.Ekle2("Elma", "Yesil Elma", 29);
            sepetManager.Ekle2("Karpuz", "Diyarbakir", 29);

            Console.ReadLine();
        }
    }
}


// DO NOT REPEAT YOURSELF
