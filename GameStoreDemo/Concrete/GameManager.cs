using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Save(Game game)
        {
            Console.WriteLine(game.Name + " is added!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " is updated!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " is deleted!");
        }
        
    }
}
