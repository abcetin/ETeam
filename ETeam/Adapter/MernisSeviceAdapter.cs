using ETeam.Abstract;
using ETeam.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace ETeam.Adapter
{
    public class MernisSeviceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoap clien1 = new KPSPublicSoapClient();
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
