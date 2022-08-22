using CoffeeShops_CMS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShops_CMS.Business.Abstracts
{
    interface ICustomerService
    {
        void Save(Customer customer);
    }
}
