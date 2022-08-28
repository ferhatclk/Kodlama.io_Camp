using GameSales_MS.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales_MS.Entities.Concretes
{
    public class Sales : IEntity
    {
        public int SalesId { get; set; }
        public Gamer Gamer { get; set; }
        public Game Game { get; set; }
        // Kampanya uygulanmaz ise default değer olarak indirim oranı 0 olan bir campanya uygulayacak
        public Campaign Campaign { get; set; } = new Campaign { CampaignDiscount=0};
        public double TotalPrice { get; set; }
    }
}
