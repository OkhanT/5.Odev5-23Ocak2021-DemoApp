using _5.Odev5_23Ocak2021_DemoApp.Abstract;
using _5.Odev5_23Ocak2021_DemoApp.Adapter;
using _5.Odev5_23Ocak2021_DemoApp.Concrete;
using _5.Odev5_23Ocak2021_DemoApp.Entities;
using System;

namespace _5.Odev5_23Ocak2021_DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                GamerId = 1,
                GamerFirstName = "Mehmet Okhan",
                GamerLastName = "Tanrıverdi",
                NationalityId = "24677370624",
                GamerNickName = "McCarthy",
                DateOfBirth = new DateTime(1995, 4, 26)                

            };

            Campaign campaign = new Campaign
            {
                CampaignId = 1,
                CampaignName = "Last Discount",
                RateOfDiscount = 25

            };

            BaseGamerManager baseGamerManager = new GamerManager(new MernisServiceAdapter());
            baseGamerManager.Save(gamer);
            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign);

            IGameSalesService gameSalesService = new GameSalesManager();
            gameSalesService.Sell(gamer, campaign);

        }
    }
}
