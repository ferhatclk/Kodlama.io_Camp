using GameSales_MS.Business.Abstracts;
using GameSales_MS.DataAccess.Concretes;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Business.Concretes
{
    public class CampaignManager : ICampaignService
    {
        CampaignRepository campaignRepository;

        public CampaignManager(CampaignRepository campaignRepository)
        {
            this.campaignRepository = campaignRepository;
        }

        public void Add(Campaign campaign)
        {
            campaignRepository.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            campaignRepository.Delete(campaign);
        }

        public List<Campaign> GetAll()
        {
            return campaignRepository.GetAll();
        }

        public void Update(Campaign campaign)
        {
            campaignRepository.Update(campaign);
        }
    }
}
