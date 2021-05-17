using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Entities;
using System;

namespace InterfacesAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        public IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            throw new Exception("Not a valid person");

        }

    }
}
