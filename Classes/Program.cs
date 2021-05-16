using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Taha";
            customer.LastName = "Kocal";
            customer.City = "Istanbul";

            Customer customer2 = new Customer { Id = 1, FirstName = "Kemal", LastName = "Guler", City = "Istanbul" };


            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
