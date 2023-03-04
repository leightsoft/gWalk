using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigame
{
    internal class Movement
    {
        // метод который уменьшает y и двигает игрока вверх
        public static void MoveW()
        {
            switch (Program.Screen[Program.yPlayer - 1, Program.xPlayer])
            {
                case '#':
                    break; // не даем пройти в стену
                case '&':
                    Console.WriteLine("GAME OVER!");
                    Environment.Exit(0);
                    break;
                case '%':
                    Console.WriteLine("YOU WIN!!!");
                    Environment.Exit(0);
                    break;
                case '$':
                    Program.Coins += 1;
                    goto default;
                default:
                    Program.Screen[Program.yPlayer, Program.xPlayer] = '.'; // заменяем прошлую позицию на .
                    Program.yPlayer -= 1;
                    break;
            }
            
        }

        // метод который увеличивает y и двигает игрока вниз
        public static void MoveS()
        {
            switch (Program.Screen[Program.yPlayer + 1, Program.xPlayer])
            {
                case '#':
                    break; // не даем пройти в стену
                case '&':
                    Console.WriteLine("GAME OVER!");
                    Environment.Exit(0);
                    break;
                case '%':
                    Console.WriteLine("YOU WIN!!!");
                    Environment.Exit(0);
                    break;
                case '$':
                    Program.Coins += 1;
                    goto default;
                default:
                    Program.Screen[Program.yPlayer, Program.xPlayer] = '.'; // заменяем прошлую позицию на .
                    Program.yPlayer += 1;
                    break;
            }
        }

        // метод который увеличивает x и двигает игрока вправо
        public static void MoveD()
        {
            switch (Program.Screen[Program.yPlayer, Program.xPlayer + 1])
            {
                case '#':
                    break; // не даем пройти в стену
                case '&':
                    Console.WriteLine("GAME OVER!");
                    Environment.Exit(0);
                    break;
                case '%':
                    Console.WriteLine("YOU WIN!!!");
                    Environment.Exit(0);
                    break;
                case '$':
                    Program.Coins += 1;
                    goto default;
                default:
                    Program.Screen[Program.yPlayer, Program.xPlayer] = '.'; // заменяем прошлую позицию на .
                    Program.xPlayer += 1;
                    break;
            }
        }

        // метод который уменьшает x и двигает игрока влево
        public static void MoveA()
        {
            switch (Program.Screen[Program.yPlayer, Program.xPlayer - 1])
            {
                case '#':
                    break; // не даем пройти в стену
                case '&':
                    Console.WriteLine("GAME OVER!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case '%':
                    Console.WriteLine("YOU WIN!!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case '$':
                    Program.Coins += 1;
                    goto default;
                default:
                    Program.Screen[Program.yPlayer, Program.xPlayer] = '.'; // заменяем прошлую позицию на .
                    Program.xPlayer -= 1;
                    break;
            }
        }
    }
}
