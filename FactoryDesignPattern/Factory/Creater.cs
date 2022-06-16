using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Creater
    {
        public Games FactoryMethod(GameTypes gameTypes)
        {
            Games games = null;
            switch (gameTypes)
            {
                case GameTypes.Atari:
                    games = new Atari();
                    break;
                case GameTypes.Playstation:
                    games = new Playstation();
                    break;
                case GameTypes.Computer:
                    games = new Computer();
                    break;
                default:
                    break;
            }
            return games;
        }
    }
}
