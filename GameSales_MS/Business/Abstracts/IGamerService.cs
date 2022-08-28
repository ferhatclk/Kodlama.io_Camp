using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Business.Abstracts
{
    public interface IGamerService
    {
        void Add(Gamer gamer);

        void Delete(Gamer gamer);

        void Update(Gamer gamer);

        List<Gamer> GetAll();
    }
}
