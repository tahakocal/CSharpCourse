using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taha Kocal
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.MusteriNo = "241234123";
            customer1.FirstName = "Taha";
            customer1.LastName = "Kocal";
            customer1.TcNo = "12313241234123";

            // Logitech
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.MusteriNo = "234412344";
            customer2.CompanyName = "Logitech";
            customer2.VergiNo = "23141234";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }

    }

}
