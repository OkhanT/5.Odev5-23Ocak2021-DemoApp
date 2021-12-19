using _5.Odev5_23Ocak2021_DemoApp.Abstract;
using _5.Odev5_23Ocak2021_DemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Odev5_23Ocak2021_DemoApp.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaing)
        {
            Console.WriteLine("added " + campaing.CampaignName);
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine("deleted " + campaing.CampaignName);
        }

        public void Update(Campaign campaing)
        {
            Console.WriteLine("updated " + campaing.CampaignName);
        }
    }
}
