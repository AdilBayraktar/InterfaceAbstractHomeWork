using InterfaceAbstractHomeWork.Abstracts;
using InterfaceAbstractHomeWork.Concrete;
using InterfaceAbstractHomeWork.Entities;
using System;

namespace InterfaceAbstractHomeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Gammers
            Gammer gammer1 = new Gammer { Id = 1, FirstName = "Adil", LastName = "Bayraktar", BirthDate = new DateTime(1997, 1, 1), NationlityId = "123456789" };
            Gammer gammer2 = new Gammer { Id = 2, FirstName = "Ali", LastName = "Aslan", BirthDate = new DateTime(2001, 5, 28), NationlityId = "546831282" };

            IGammerService gammer = new GammerManager();
            gammer.Add(gammer1);
            gammer.Update(gammer1);
            gammer.Add(gammer2);
            gammer.Delete(gammer2);

            Console.WriteLine("-----------------------------");

            //Games
            Games game1 = new Games { Id = 01, GameName = "Gta", GameType = "Action" };
            Games game2 = new Games { Id = 02, GameName = "Cs", GameType = "Action" };

            IGamesService game = new GamesManager();
            game.Buy(gammer1, game1);
            game.Buy(gammer2, game2);
            Console.WriteLine("-----------------------------");

            //Campaigns
            Campaign campaign1 = new Campaign { campaignId = 001, campaignRange = 25 };
            Campaign campaign2 = new Campaign { campaignId = 002, campaignRange = 65 };

            ICampaignService campaign = new CampaignManager();

            campaign.Discount(game1, campaign1);
            campaign.Discount(game2, campaign2);
        }
    }
}