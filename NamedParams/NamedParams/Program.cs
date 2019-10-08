using System;

namespace NamedParams
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFancyMessage(message: "privet", backgroundColor: ConsoleColor.Blue, textColor : ConsoleColor.Yellow);
            DisplayFancyMessage(textColor: ConsoleColor.Yellow, message: "privet", backgroundColor: ConsoleColor.Blue );
            DisplayFancyMessage(backgroundColor: ConsoleColor.Blue, textColor: ConsoleColor.Yellow,  message: "privet");

            DisplayFancyMessageOptionalParams();
            DisplayFancyMessageOptionalParams(message : "SHREK");
            DisplayFancyMessageOptionalParams(textColor : ConsoleColor.Cyan);
            DisplayFancyMessageOptionalParams(backgroundColor: ConsoleColor.DarkMagenta);

            Console.ReadKey();
        }

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }




        static void DisplayFancyMessageOptionalParams(
            ConsoleColor textColor = ConsoleColor.White,
            ConsoleColor backgroundColor = ConsoleColor.DarkYellow, 
            string message = "hi")
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}
