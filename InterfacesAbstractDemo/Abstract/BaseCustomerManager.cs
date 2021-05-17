using InterfacesAbstractDemo.Entities;
using System;

namespace InterfacesAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to database " + customer.FirstName + " " + customer.LastName);
        }
    }
}
