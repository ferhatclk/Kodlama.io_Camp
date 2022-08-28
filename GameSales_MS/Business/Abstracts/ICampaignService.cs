using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Business.Abstracts
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        List<Campaign> GetAll();
    }
}
