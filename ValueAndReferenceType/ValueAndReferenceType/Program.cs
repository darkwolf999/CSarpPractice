using System;

namespace ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать первую переменную Rectangle.
            Console.WriteLine("-> Creating rl");
            Rectangle rl = new Rectangle("First Rect", 10, 10, 50, 50);
            rl.Display();
            // Присвоить новой переменной Rectangle переменную rl.
            Console.WriteLine("-> Assigning r2 to rl");
            Rectangle r2 = rl;
            rl.Display();
            r2.Display();
            // Изменить некоторые значения в r2.
            Console.WriteLine("-> Changing values of r2");
            r2.ShInfo.Info = "This is new info!";
            r2.Bottom = 4444;
            // Вывести значения из обеих переменных Rectangle,
            rl.Display();
            r2.Display();

            Console.ReadKey();
        }
    }
}
