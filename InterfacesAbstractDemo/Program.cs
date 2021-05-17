using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Adopters;
using InterfacesAbstractDemo.Concrete;
using InterfacesAbstractDemo.Entities;
using System;

namespace InterfacesAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2002, 03, 06), FirstName = "Mehmet Taha", LastName = "Kocal", NationalityId = 22607536348 });
        }
    }
}
