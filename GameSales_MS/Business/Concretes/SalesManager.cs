using GameSales_MS.Business.Abstracts;
using GameSales_MS.DataAccess.Concretes;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Business.Concretes
{
    public class SalesManager : ISalesService
    {
        SalesRepository salesRepository;

        public SalesManager(SalesRepository salesRepository)
        {
            this.salesRepository = salesRepository;
        }

        public void Add(Sales sales)
        {
            sales.TotalPrice =(sales.Game.UnitPrice - ((sales.Game.UnitPrice) * (sales.Campaign.CampaignDiscount)));
            salesRepository.Add(sales); 
        }

        public void Delete(Sales sales)
        {
            salesRepository.Delete(sales);
        }

        public List<Sales> GetAll()
        {
            return salesRepository.GetAll();
        }

        public void Update(Sales sales)
        {
            salesRepository.Update(sales);
        }
    }
}
