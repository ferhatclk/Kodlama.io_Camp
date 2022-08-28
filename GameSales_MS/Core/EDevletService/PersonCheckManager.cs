using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Core.EDevletService
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfExistPerson(Gamer gamer)
        {
            bool result = (!gamer.FirstName.Equals(null)) && (!gamer.LastName.Equals(null)) &&
                (gamer.BirthYear.Year > 1900 && gamer.BirthYear.Year < 2022) &&
                (gamer.NationalId.Length == 11);

            return result;
        }
    }
}
