using GameSales_MS.Business.Abstracts;
using GameSales_MS.Business.Concretes;
using GameSales_MS.Core.EDevletService;
using GameSales_MS.DataAccess.Concretes;
using GameSales_MS.Entities.Concretes;
using System;

namespace GameSales_MS
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { GamerId = 1, FirstName = "Ferhat", LastName = "ÇELİK", NationalId = "12345678910", BirthYear = new DateTime(1994, 2, 1) };

            Gamer gamer2 = new Gamer();
            gamer2.GamerId = 2;
            gamer2.FirstName = "Zehra";
            gamer2.LastName = "Çamlı";
            gamer2.NationalId = "12365498711";
            gamer2.BirthYear = new DateTime(1998, 05, 12);


            IGamerService customerService = new GamerManager(new GamerRepository(), new PersonCheckManager());
            customerService.Add(gamer1);
            customerService.Add(gamer2);

            Game game1 = new Game {GameId = 1, GameName = "Call Of Duty", UnitPrice = 100 };

            IGameService gameService = new GameManager(new GameRepository());
            gameService.Add(game1);

            Campaign campaign1 = new Campaign { CampaignId = 1, CampaignName = "Herkes için Oyun", CampaignDiscount = 0.2 };

            ICampaignService campaignService = new CampaignManager(new CampaignRepository());
            campaignService.Add(campaign1);

            ISalesService salesService = new SalesManager(new SalesRepository());
            salesService.Add(new Sales { SalesId = 1, Game = game1, Campaign = campaign1 });
            
            foreach (var sales in salesService.GetAll())
            {
                Console.WriteLine(sales.Game.GameName +" : "+sales.Campaign.CampaignName);
                Console.WriteLine(sales.Game.UnitPrice + " -> " + sales.Campaign.CampaignDiscount + " : " + sales.TotalPrice);
            }
            
        }
    }
}
