using _5.Odev5_23Ocak2021_DemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Odev5_23Ocak2021_DemoApp.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaing);
        void Delete(Campaign campaing);
        void Update(Campaign campaing);

    }
}
