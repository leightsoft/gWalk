using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigame
{
    internal class Shooting
    {
        public static void ShootU()
        {
            Program.Cartridges -= 1; // забираем патрон
            Program.Screen[Program.yPlayer - 1, Program.xPlayer] = '.';
        }

        public static void ShootN()
        {
            Program.Cartridges -= 1; // забираем патрон
            Program.Screen[Program.yPlayer + 1, Program.xPlayer] = '.';
        }

        public static void ShootH()
        {
            Program.Cartridges -= 1; // забираем патрон
            Program.Screen[Program.yPlayer, Program.xPlayer - 1] = '.';
        }

        public static void ShootK()
        {
            Program.Cartridges -= 1; // забираем патрон
            Program.Screen[Program.yPlayer, Program.xPlayer + 1] = '.';
        }
    }
}
