using GameSales_MS.DataAccess.Abstracts;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.DataAccess.Concretes
{
    public class SalesRepository : IRepository<Sales>
    {
        List<Sales> saleses = new List<Sales>();
        public void Add(Sales sales)
        {
            saleses.Add(sales);
        }

        public void Delete(Sales sales)
        {
            saleses.Remove(sales);
        }

        public List<Sales> GetAll()
        {
            return saleses;
        }

        public void Update(Sales sales)
        {
            foreach (var item in saleses)
            {
                if (item.SalesId==sales.SalesId)
                {
                    item.Game = sales.Game;
                    item.Gamer = sales.Gamer;
                    item.TotalPrice = sales.TotalPrice;
                }
            }
        }
    }
}
