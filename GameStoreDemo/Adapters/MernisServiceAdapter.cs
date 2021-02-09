using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        { // Ok but?
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(player.NationalityId, player.FirstName, player.LastName, player.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
