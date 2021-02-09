using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concrete
{
    public class SteamPlayerManager : BasePlayerManager
    {
        IPlayerCheckService _playerCheckService;

        public SteamPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Register(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player)) // true ise
            {
                base.Register(player);
            }
            else
            {
                throw new Exception("Not a valid person!");
            }
        }

    }
}
