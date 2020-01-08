using System;
using System.Drawing;
using System.Threading;

namespace ASCIIMap
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] mapSymbols = ManualMapInit();
            //char[] mapSymbols = AutoMapInit();

            //int drawSpeedDelay = 20;

            //while (true)
            //{
            //    DrawMap(mapSymbols, drawSpeedDelay);
            //    Console.Clear();
            //}


            ////////////////////////////////////////////////////////////////////////////////////////

            Point curPos = new Point(0, 30);
            Console.SetCursorPosition(curPos.X, curPos.Y);
            char prevSymbol = ' ';

            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                    DrawHandly('-', ref prevSymbol, ref curPos);
                else if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                    DrawHandly('/', ref prevSymbol, ref curPos);
                else if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                    DrawHandly('\\', ref prevSymbol, ref curPos);
            }

            Console.Read();
        }

        public static char[] ManualMapInit()
        {
            string mapLine = Console.ReadLine();
            return mapLine.ToCharArray();
        }

        public static char[] AutoMapInit()
        {
            char[] mapSymbols = { '/', '-', '-', '\\', '\\', '\\', '/', '-', '-', '\\', '\\', '\\', '\\', '/', '-', '-', '/', '\\', '/', '/', '/', '/', '/', '/', '/', '/', '-', '-', '/', '-', '-', '-', '/', '-', '-', '\\', '\\', '\\', '\\', '/', '-', '-', '/', '\\', '\\', '\\', '/', '\\', '/', '-', '-', '\\', '\\', '\\', '\\', '/', '-', '-', '/', '\\', '\\', '-', '-', '-', '-', '-', '-', '\\', '\\', '\\', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '/', '/', '/', '/', '/', '\\', '\\', '\\', '/', '-', '/', '/', '-', '-', '/', '-', '-', '-', '/', '-', '-', '\\', '\\', '\\', '\\', '/', '-', '-', '/', '\\' };
            return mapSymbols;
        }

        public static void DrawMap(char[] mapSymbols, int drawSpeedDelay)
        {
            foreach (char symbol in mapSymbols)
            {
                Thread.Sleep(drawSpeedDelay);
                Console.Write(symbol);
            }

            int posX = 0, posY = 20;
            Console.SetCursorPosition(posX, posY);

            for (int i = 0; i < mapSymbols.Length - 1; i++)
            {
                Thread.Sleep(drawSpeedDelay);

                Console.WriteLine(mapSymbols[i]);

                if ((mapSymbols[i] == '/' && mapSymbols[i + 1] == '/') ||
                    (mapSymbols[i] == '/' && mapSymbols[i + 1] == '-') ||
                    (mapSymbols[i] == '-' && mapSymbols[i + 1] == '/'))
                {
                    posY--;
                }

                else if ((mapSymbols[i] == '-' && mapSymbols[i + 1] == '\\') ||
                         (mapSymbols[i] == '\\' && mapSymbols[i + 1] == '-') ||
                         (mapSymbols[i] == '\\' && mapSymbols[i + 1] == '\\'))
                {
                    posY++;
                }

                Console.SetCursorPosition(posX + i + 1, posY);

            }

            Console.WriteLine(mapSymbols[mapSymbols.Length - 1]);

        }

        public static void DrawHandly(char curSymbol, ref char prevSymbol, ref Point curPos)
        {
            if ((prevSymbol == '/' && curSymbol == '/') ||
                (prevSymbol == '/' && curSymbol == '-') ||
                (prevSymbol == '-' && curSymbol == '/'))
            {
                curPos.Y--;
            }

            else if ((prevSymbol == '-' && curSymbol == '\\') ||
                     (prevSymbol == '\\' && curSymbol == '-') ||
                     (prevSymbol == '\\' && curSymbol == '\\'))
            {
                curPos.Y++;
            }

            Console.SetCursorPosition(curPos.X, curPos.Y);

            Console.WriteLine(curSymbol);

            Console.SetCursorPosition(curPos.X++, curPos.Y);

            prevSymbol = curSymbol;
        }
    }
}
