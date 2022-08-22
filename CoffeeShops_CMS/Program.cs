using CoffeeShops_CMS.Business.Abstracts;
using CoffeeShops_CMS.Business.Concretes;
using CoffeeShops_CMS.Core.Adapters;
using CoffeeShops_CMS.Entities.Concretes;
using System;

namespace CoffeeShops_CMS
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998, 1, 2),FirstName="Ferhat",LastName="ÇELİK" ,Id=1,NationalityId="0521464879"});
        }
    }
}
