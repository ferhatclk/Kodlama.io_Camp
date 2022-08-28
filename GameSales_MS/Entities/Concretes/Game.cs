using GameSales_MS.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Entities.Concretes
{
    public class Game : IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double UnitPrice { get; set; }
    }
}
