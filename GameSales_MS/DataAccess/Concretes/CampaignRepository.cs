using GameSales_MS.DataAccess.Abstracts;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.DataAccess.Concretes
{
    public class CampaignRepository : IRepository<Campaign>
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
        }

        public List<Campaign> GetAll()
        {
            return campaigns;
        }

        public void Update(Campaign campaign)
        {
            foreach (var item in campaigns)
            {
                if (item.CampaignId == campaign.CampaignId)
                {
                    item.CampaignName = campaign.CampaignName;
                    item.CampaignDiscount = campaign.CampaignDiscount;
                }
            }
        }
    }
}
