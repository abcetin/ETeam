using ETeam.Abstract;
using ETeam.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETeam.Concrete
{
    public class GamerCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public GamerCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
