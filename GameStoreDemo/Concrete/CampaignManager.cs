using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is added!");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is updated!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is deleted!");
        }
        
    }
}
