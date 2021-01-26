using ETeam.Abstract;
using ETeam.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETeam.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
