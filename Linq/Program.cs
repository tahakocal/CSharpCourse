using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1,CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2,CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1,CategoryId = 1,ProductName = "Msi Leptop",QuantityPerUnit = "16 GB RAM",UnitPrice = 12000,UnitInStock = 5},
                new Product { ProductId = 2,CategoryId = 1,ProductName = "Asus Leptop",QuantityPerUnit = "8 GB RAM",UnitPrice = 11000,UnitInStock = 3},
                new Product { ProductId = 3,CategoryId = 1,ProductName = "Monster Leptop",QuantityPerUnit = "32 GB RAM",UnitPrice = 16000,UnitInStock = 2},
                new Product { ProductId = 4,CategoryId = 2,ProductName = " Xiomi Telefon",QuantityPerUnit = "6 GB RAM",UnitPrice = 4000,UnitInStock = 15},
                new Product { ProductId = 5,CategoryId = 2,ProductName = "Iphone Telefon",QuantityPerUnit = "4 GB RAM",UnitPrice = 9000,UnitInStock = 0},
            };

            //Test(products);
            //GetProducts(products);
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDescTest(products);
            //ClassicLinqTest(products);


            var result = from p in products
                join c in categories
                    on p.CategoryId equals c.CategoryId
                    where p.UnitPrice>5000
                orderby p.UnitPrice descending 
                select new ProductDTO
                {
                    ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice,
                    CategoryName = c.CategoryName
                };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0} ---- {1} ", productDto.ProductName, productDto.CategoryName);
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                where p.UnitPrice > 6000
                orderby p.UnitPrice
                select new ProductDTO {ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice};

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice)
                .ThenBy(p =>
                    p.ProductName); // icinde top gecenleri sectik daha sonra fiyata gore siraladik en sonda eger fiyatlari esit olan varsa onlari da kendi aralarinda alfabetik olarak siraladik

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top")); // istedgimiz bilgiye sahip butun verileri buluyo
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3); //verdigimiz bilgiye uygun bilgileri buluyor 
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Msi Leptop"); // Any komutu yazili olan esyadan var mi anlamina geliyor true veya false dondurur
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("-----------------Algoritmik---------------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("--------------------Linq------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }


        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();

        }



    }

    class ProductDTO
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }


    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
