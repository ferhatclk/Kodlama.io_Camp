using GameSales_MS.Business.Abstracts;
using GameSales_MS.Core.EDevletService;
using GameSales_MS.DataAccess.Concretes;
using GameSales_MS.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Business.Concretes
{
    public class GamerManager : IGamerService
    {
        GamerRepository gamerRepository;
        IPersonCheckService personCheckService;

        public GamerManager(GamerRepository customerRepository, IPersonCheckService personCheckService)
        {
            this.gamerRepository = customerRepository;
            this.personCheckService = personCheckService;
        }

        public void Add(Gamer gamer)
        {

            if (personCheckService.CheckIfExistPerson(gamer))
            {
                gamerRepository.Add(gamer);
                Console.WriteLine("Müşteri eklendi : " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Böyle bir kişi mevcut değil!!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            gamerRepository.Delete(gamer);
            Console.WriteLine("Müşteri silindi : " + gamer.FirstName);
        }

        public List<Gamer> GetAll()
        {
            return  gamerRepository.GetAll();
        }

        public void Update(Gamer gamer)
        {
            gamerRepository.Update(gamer);
            Console.WriteLine("Müşteri güncellendi : " + gamer.FirstName);
        }
    }
}
