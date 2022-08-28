using GameSales_MS.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Entities.Concretes
{
    public class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
    }
}
