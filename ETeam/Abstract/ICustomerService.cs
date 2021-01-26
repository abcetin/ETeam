using ETeam.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETeam.Abstract
{
    interface ICustomerService
    {
        void Library(Customer customer);
        void Save(Customer customer);
        void Download();
        void Upload(Customer customer);
        void NewCampaign(Customer customer);
        void RemoveCampaign(Customer customer);
        void UpdateCampaign(Customer customer);

    }
}
