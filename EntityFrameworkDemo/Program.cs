using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //NorthwindContext northwindContext = new NorthwindContext();

            //foreach (var product in northwindContext.Products)
            //{
            //    Console.WriteLine(product.ProductName);
            //}


        }

        private static void GetProductByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

        }

    }
}
