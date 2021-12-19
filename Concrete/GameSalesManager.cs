using _5.Odev5_23Ocak2021_DemoApp.Abstract;
using _5.Odev5_23Ocak2021_DemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Odev5_23Ocak2021_DemoApp.Concrete
{
    class GameSalesManager : IGameSalesService
    {
        public void Sell(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerFirstName + " sold the game with " + campaign.CampaignName + " and " + "rate of campaign " + campaign.RateOfDiscount);
        }

        
    }
}
