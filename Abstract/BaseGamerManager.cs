using _5.Odev5_23Ocak2021_DemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Odev5_23Ocak2021_DemoApp.Abstract
{
    abstract class BaseGamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("deleted " + gamer.GamerFirstName);
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("saved " + "First Name: " + gamer.GamerFirstName + "Last Name: " + gamer.GamerLastName + "Nickname oF gamer: " + gamer.GamerNickName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("updated " + gamer.GamerFirstName);
        }
    }
}
