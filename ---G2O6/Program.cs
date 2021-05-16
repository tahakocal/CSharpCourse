using System;

namespace ___G2O6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Renk = "Mavi";
            product1.Beden = "S";
            product1.urunAdedi = 150;

            Product product2 = new Product();
            product2.Renk = "Kirmizi";
            product2.Beden = "M";
            product2.urunAdedi = 250;

            Product product3 = new Product();
            product3.Renk = "Yesil";
            product3.Beden = "L";
            product3.urunAdedi = 375;

            Product product4 = new Product();
            product4.Renk = "Sari";
            product4.Beden = "XL";
            product4.urunAdedi = 100;

            Product[] products = new Product[] { product1, product2, product3, product4 };

            Console.WriteLine("**************FOR EACH**************");
            foreach (var product in products)
            {
                Console.WriteLine("Renk: " + product.Renk + " Beden: " + product.Beden + " Urun Adedi: " + product.urunAdedi);
            }

            Console.WriteLine("****************FOR*****************");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Renk);
                Console.WriteLine(products[i].Beden);
                Console.WriteLine(products[i].urunAdedi);
            }

            Console.ReadLine();
        }
    }

    class Product
    {
        public string Renk { get; set; }
        public string Beden { get; set; }
        public int urunAdedi { get; set; }
    }
}
