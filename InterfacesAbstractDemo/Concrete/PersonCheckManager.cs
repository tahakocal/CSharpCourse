using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Entities;

namespace InterfacesAbstractDemo.Concrete
{
    class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
