using CoffeeShops_CMS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShops_CMS.Business.Abstracts
{
    abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : "+ customer.FirstName);
        }
    }
}
