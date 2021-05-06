using InterfaceAbstractHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractHomeWork.Abstracts
{
    internal interface ICampaignService
    {
        void Discount(Games game, Campaign campaign);
    }
}