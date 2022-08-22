using CoffeeShops_CMS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShops_CMS.Core.MernisService
{
    class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
