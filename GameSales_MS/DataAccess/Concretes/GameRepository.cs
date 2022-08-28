using GameSales_MS.DataAccess.Abstracts;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.DataAccess.Concretes
{
    public class GameRepository : IRepository<Game>
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            games.Add(game);
        }

        public void Delete(Game game)
        {
            games.Remove(game);
        }

        public List<Game> GetAll()
        {
            return games;
        }

        public void Update(Game game)
        {
            foreach (var item in games)
            {
                if (item.GameId == game.GameId)
                {
                    item.GameName = game.GameName;
                    item.UnitPrice = game.UnitPrice;
                }
            }
        }
    }
}
