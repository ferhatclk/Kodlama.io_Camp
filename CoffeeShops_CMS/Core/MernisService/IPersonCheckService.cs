using CoffeeShops_CMS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShops_CMS.Core.MernisService
{
    interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
