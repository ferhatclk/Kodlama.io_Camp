using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Business.Abstracts
{
    public interface ISalesService
    {
        void Add(Sales sales);
        void Delete(Sales sales);
        void Update(Sales sales);
        List<Sales> GetAll();
    }
}
