using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Register(Player player)
        {
            Console.WriteLine("Player {0} {1} is added!", player.FirstName, player.LastName);
        }
        public virtual void UpdateInformation(Player player)
        {
            Console.WriteLine("Player {0} {1} is updated!", player.FirstName, player.LastName);
        }

        public virtual void DeleteAccount(Player player)
        {
            Console.WriteLine("Player {0} {1} is deleted!", player.FirstName, player.LastName);
        }
    }
}
