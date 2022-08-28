using GameSales_MS.DataAccess.Abstracts;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.DataAccess.Concretes
{
    public class GamerRepository : IRepository<Gamer>
    {
        List<Gamer> gamers = new List<Gamer>();
        
        public void Add(Gamer gamer)
        {
            gamers.Add(gamer);
        }

        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
        }

        public List<Gamer> GetAll()
        {
            return gamers;
        }

        public void Update(Gamer gamer)
        {
            foreach (var item in gamers)
            {
                if (item.GamerId== gamer.GamerId)
                {
                    item.FirstName = gamer.FirstName;
                    item.LastName = gamer.LastName;
                    item.NationalId = gamer.NationalId;
                    item.BirthYear = gamer.BirthYear;
                }
            }
        }
    }
}
