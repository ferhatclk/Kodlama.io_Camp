using CoffeeShops_CMS.Business.Abstracts;
using CoffeeShops_CMS.Core.MernisService;
using CoffeeShops_CMS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShops_CMS.Business.Concretes
{
    class StarbucksCustomerManager : BaseCustomerManager
    {
        IPersonCheckService personCheckService;

        public StarbucksCustomerManager()
        {
        }

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            this.personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

    }
}
