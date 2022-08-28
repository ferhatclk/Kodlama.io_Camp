using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.DataAccess.Abstracts
{
    public interface IRepository<T>
    {

        void Add(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetAll();
    }

}
