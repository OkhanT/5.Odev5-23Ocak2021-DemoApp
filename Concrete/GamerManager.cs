using _5.Odev5_23Ocak2021_DemoApp.Abstract;
using _5.Odev5_23Ocak2021_DemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Odev5_23Ocak2021_DemoApp.Concrete
{
    class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a volid gamer.");
            }
            
        }
    }
}
