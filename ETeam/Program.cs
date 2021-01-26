using ETeam.Abstract;
using ETeam.Adapter;
using ETeam.Concrete;
using ETeam.Entites;
using System;

namespace ETeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { DateOfBirth = new DateTime(1996, 1, 9), FirstName = "Abdullah", LastName = "ÇETİN", NationalId = "123456", CustomerTag = "Influencer" };
            Customer customer2 = new Customer() { DateOfBirth = new DateTime(2000, 10, 17), FirstName = "Yasin", LastName = "ÇETİN", NationalId = "456321", CustomerTag = "Gamer" };

            BaseCustomerManager baseCustomerManager1 = new GamerCustomerManager(new MernisSeviceAdapter());
            //baseCustomerManager1.Save(customer1); mernisle alakalı yaşadığım bir sorundan dolayı iptal etmek zorunda kaldım
            baseCustomerManager1.NewCampaign(customer1);
            baseCustomerManager1.RemoveCampaign(customer1);
            baseCustomerManager1.UpdateCampaign(customer1);
            baseCustomerManager1.Download();
            baseCustomerManager1.Upload(customer1);
            baseCustomerManager1.Library(customer1);

            Console.WriteLine("*************************************************************************************");
            BaseCustomerManager baseCustomerManager2 = new GamerCustomerManager(new MernisSeviceAdapter());
            //baseCustomerManager1.Save(customer1); mernisle alakalı yaşadığım bir sorundan dolayı iptal etmek zorunda kaldım
            baseCustomerManager2.NewCampaign(customer2);
            baseCustomerManager2.RemoveCampaign(customer2);
            baseCustomerManager2.UpdateCampaign(customer2);
            baseCustomerManager2.Download();
            baseCustomerManager2.Upload(customer2);
            baseCustomerManager2.Library(customer2);





            Console.ReadLine();
        }
    }
}
