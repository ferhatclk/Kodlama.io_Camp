using GameSales_MS.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Entities.Concretes
{
    public class Gamer : IEntity
    {
        public int GamerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime BirthYear { get; set; }
    }
}
