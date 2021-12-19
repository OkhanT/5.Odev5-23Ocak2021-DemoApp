using _5.Odev5_23Ocak2021_DemoApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Odev5_23Ocak2021_DemoApp.Entities
{
    class Gamer : IEntities
    {
        public int GamerId { get; set; }
        public string GamerFirstName { get; set; }
        public string GamerLastName { get; set; }
        public string GamerNickName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
