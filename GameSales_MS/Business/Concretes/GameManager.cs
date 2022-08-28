using GameSales_MS.Business.Abstracts;
using GameSales_MS.DataAccess.Concretes;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Business.Concretes
{
    public class GameManager : IGameService
    {
        GameRepository gameRepository;

        public GameManager(GameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public void Add(Game game)
        {
            gameRepository.Add(game);
        }

        public void Delete(Game game)
        {
            gameRepository.Delete(game);
        }

        public List<Game> GetAll()
        {
            return gameRepository.GetAll();
        }

        public void Update(Game game)
        {
            gameRepository.Update(game);
        }
    }
}
