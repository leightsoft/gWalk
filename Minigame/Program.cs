//
//
//=======================gWalk2d by PARASHASOFT(empty)==============================
//           ---Special thanks for nik0dy, blackZ, konsultant eldorado--- 
//
//
//                     prod: parashasoft soundtrack: ParashaSoft
//
namespace Minigame
{
    internal class Program
    {
        public static Random random = new Random();

        public static int Coins = 0; // Монетки игрока
        public static int coinsCount = random.Next(10, 20);
        public static int Cartridges = random.Next(3, 8); // Патроны игрока
        
        // Переменные для установки позиции игрока
        public static int xPlayer = 0;
        public static int yPlayer = 0;

        // Переменные для установки позиции выхода
        public static int xEscape = 0;
        public static int yEscape = 0;

        public static int xWall, yWall; // Переменные для установки позиции стен
        public static int xCoin, yCoin; // Переменные для установки позиции монеток
        public static int xBomb, yBomb; // Переменные для установки позиции бомб

        // Создаем экран для игры
        public static char[,] Screen = {
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }};

        static void Main(string[] args)
        {
            // генератор монеток
            for (int i = 0; i < coinsCount; i++) // Здесь рандом нужен для количества монеток
            {
                xCoin = random.Next(0, 10); // генерируем позицию монетки по x
                yCoin = random.Next(0, 10); // генерируем позицию монетки по y
                Screen[yCoin, xCoin] = '$';
            }

            // генератор мин
            for (int i = 0; i < random.Next(7, 10); i++) // Здесь рандом нужен для количества мин
            {
                xBomb = random.Next(0, 10); // генерируем позицию мины по x
                yBomb = random.Next(0, 10); // генерируем позицию мины по y
                Screen[yBomb, xBomb] = '&';
            }

            // генератор стен
            for (int i = 0; i < random.Next(10, 14); i++) // Здесь рандом нужен для количества стен
            {
                xBomb = random.Next(0, 10); // генерируем позицию стены по x
                yBomb = random.Next(0, 10); // генерируем позицию стены по y
                Screen[yBomb, xBomb] = '#';
            }

            // генератор выхода
            xEscape = random.Next(0, 10); // генерируем позицию выхода по x
            yEscape = random.Next(0, 10); // генерируем позицию выхода по y
            Screen[yEscape, xEscape] = '%';

            // Приветствие
            Console.WriteLine("                                             __      __    _ _   ");
            Console.WriteLine("                                          __ \\ \\    / /_ _| | |__");
            Console.WriteLine("                                         / _` \\ \\/\\/ / _` | | / /         by ParashaSoft");
            Console.WriteLine("                                         \\__, |\\_/\\_/\\__,_|_|_\\_\\");
            Console.WriteLine("                                         |___/                   ");
            Console.WriteLine("                                                                        ");
            Console.WriteLine("                                               Start - Spacebar");
            Console.WriteLine("                                               Authors - A");
            Console.WriteLine("                                               Exit - Any key");
            // проверяем что делаем в главном меню
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Spacebar: // начинаем игру
                    break;
                case ConsoleKey.A: //титры
                    Console.Clear();
                    Console.WriteLine("gWalk by ParashaSoft");
                    Console.WriteLine(" ");
                    Console.WriteLine("Prod by ParashaSoft");
                    Console.WriteLine("Gamedesign by ParashaSoft");
                    Console.WriteLine("idea by ParashaSoft");
                    Console.WriteLine("develop by empty(prosnulsa) from ParashaSoft");
                    Console.WriteLine("---------------Special thanks----------------");
                    Console.WriteLine("     BlackZ and Nik0dy from ParashaSoft");
                    Console.WriteLine("Press anykey to exit from game");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default: // уходим если клавиша не пробел
                    Environment.Exit(0);
                    break;
            }
            Console.Clear();

            // Главный цикл игры
            while (true)
            {
                Screen[yPlayer, xPlayer] = '@'; // задаем игрока

                Console.WriteLine($"Coins: {Coins}, cartrigdes: {Cartridges}"); // выводим монетки
                Console.WriteLine($"X: {xPlayer}, Y: {yPlayer}"); // выводим позицию

                // 2 цикла For для отрисовки экрана
                for (int i = 0; i < Screen.GetLength(0); i++)
                {
                    for (int j = 0; j < Screen.GetLength(1); j++)
                    {
                        Console.Write(Screen[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                // Читаем клавиши с клавиатуры для передвижения персонажа
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        Movement.MoveW();
                        break;
                    case ConsoleKey.S:
                        Movement.MoveS();
                        break;
                    case ConsoleKey.D:
                        Movement.MoveD();
                        break;
                    case ConsoleKey.A:
                        Movement.MoveA();
                        break;
                    case ConsoleKey.U:
                        // проверяем наличие патронов
                        // если есть вызываем метод из класса Shooting
                        if (Cartridges <= 0) { break; } else { Shooting.ShootU(); }
                        break;
                    case ConsoleKey.N:
                        // проверяем наличие патронов
                        // если есть вызываем метод из класса Shooting
                        if (Cartridges <= 0) { break; } else { Shooting.ShootN(); }
                        break;
                    case ConsoleKey.H:
                        // проверяем наличие патронов
                        // если есть вызываем метод из класса Shooting
                        if (Cartridges <= 0) { break; } else { Shooting.ShootH(); }
                        break;
                    case ConsoleKey.K:
                        // проверяем наличие патронов
                        // если есть вызываем метод из класса Shooting
                        if (Cartridges <= 0) { break; } else { Shooting.ShootK(); }
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
                // Очищаем консоль
                Console.Clear();
            }
        }
    }
}