using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Core.EDevletService
{
    public interface IPersonCheckService
    {
        bool CheckIfExistPerson(Gamer gamer);
    }
}
