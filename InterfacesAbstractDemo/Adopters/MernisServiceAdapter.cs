using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfacesAbstractDemo.Adopters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
