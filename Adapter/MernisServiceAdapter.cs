using _5.Odev5_23Ocak2021_DemoApp.Abstract;
using _5.Odev5_23Ocak2021_DemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;

namespace _5.Odev5_23Ocak2021_DemoApp.Adapter
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            bool result = false;

            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var resultClient = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId),gamer.GamerFirstName,gamer.GamerLastName,gamer.DateOfBirth.Year).GetAwaiter().GetResult();

            result = resultClient.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
