using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Atari : Games
    {
        public override void Platform()
        {
            Console.WriteLine("Atari Games");
        }
    }
}
