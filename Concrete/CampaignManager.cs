using InterfaceAbstractHomeWork.Abstracts;
using InterfaceAbstractHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractHomeWork.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Discount(Games game, Campaign campaign)
        {
            Console.WriteLine($"The game: {game.GameName} have a discount: {campaign.campaignRange} %");
        }
    }
}