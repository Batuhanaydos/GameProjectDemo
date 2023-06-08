using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("The game has been added to the library" + " " + game.GameName + " " + game.GameFee);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("The game has been deleted to the library" + " " + game.GameName + " " + game.GameFee);
        }

        public void Sell(Game game)
        {
            Console.WriteLine("The game has been updated to the library" + " " + game.GameName + " " + game.GameFee);
        }


    }
}