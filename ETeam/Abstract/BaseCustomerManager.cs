using ETeam.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETeam.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {


        public void Download()
        {
            Console.WriteLine("Oyun İndiriliyor...");
        }

        public void Library(Customer customer)
        {
            List<string> games = new List<string>() { "oyun1", "oyun2", "oyun3" };
            List<string> publish = new List<string>() {"Yayınlanan 1. oyun","yayınlanan 2. oyun","yayınlanan 3. oyun" };
            if (customer.CustomerTag == "Influencer")
            {
                Console.WriteLine("Oyun Kütüphanesi");
                foreach (var game in games)
                {
                    Console.WriteLine(game);
                }
            }
            else
            {
                Console.WriteLine("Yayıncı Kütüphanesi");
                foreach (var game in publish)
                {
                    Console.WriteLine(game);
                }
            }

        }

        public void NewCampaign(Customer customer)
        {
            if (customer.CustomerTag == "Influencer")
            {
                Console.WriteLine("Yeni Kampanya Yayınlandı");
            }
            else
            {
                Console.WriteLine("{0} : Bunu yapmaya yetkiniz bulunmamaktadır!!!", customer.FirstName);
            }
        }

        public void RemoveCampaign(Customer customer)
        {
            if (customer.CustomerTag == "Influencer")
            {
                Console.WriteLine("Kampanya Geçerliliğini Kaybetti");
            }
            else
            {
                Console.WriteLine("{0} : Bunu yapmaya yetkiniz bulunmamaktadır!!!", customer.FirstName);
            }
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Eteam : " + customer.FirstName);
        }

        public void UpdateCampaign(Customer customer)
        {
            if (customer.CustomerTag == "Influencer")
            {
                Console.WriteLine("Tebrikler Kampanya Başarıyla Güncellendi");
            }
            else
            {
                Console.WriteLine("{0} : Bunu yapmaya yetkiniz bulunmamaktadır!!!", customer.FirstName);
            }
        }

        public virtual void Upload(Customer customer)
        {
            if (customer.CustomerTag == "Influencer")
            {
                Console.WriteLine("Yayınladığınız Oyun Karşıya Yükleniyor...");
            }
            else
            {
                Console.WriteLine("{0} : Bunu yapmaya yetkiniz bulunmamaktadır!!!", customer.FirstName);
            }
        }
    }
}
