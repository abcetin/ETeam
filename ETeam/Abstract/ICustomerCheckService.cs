using ETeam.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETeam.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
