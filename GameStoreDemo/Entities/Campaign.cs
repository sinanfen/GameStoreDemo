using GameStoreDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Entities
{
    public class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }

    }
}
