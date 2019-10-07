using System;

namespace OptionalParams
{
    class Program
    {
        static void Main(string[] args)
        {

            EnterLogData("503");

            Console.WriteLine();

            EnterLogData("503", "User");

            Console.Read();
        }

        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

    }
}
