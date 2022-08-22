using CoffeeShops_CMS.Core.MernisService;
using CoffeeShops_CMS.Entities.Concretes;
using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShops_CMS.Core.Adapters
{
    class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
