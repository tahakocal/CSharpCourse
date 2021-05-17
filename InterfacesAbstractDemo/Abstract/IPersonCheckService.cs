using InterfacesAbstractDemo.Entities;

namespace InterfacesAbstractDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
