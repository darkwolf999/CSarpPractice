using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Working with System.Array."); 

            // Инициализировать элементы при запуске
            string[] gothicBands = {"Tones on Tail",
                                    "Bauhaus",
                                    "Sisters of Mercy",
                                    "The Cure",
                                    "The Mission",
                                    "The Cult" };

            // Вывести имена в порядке их объявления.
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            // Вывести количество измерений.
            Console.WriteLine("-> Array's rank");
            Console.WriteLine(gothicBands.Rank);

            Console.WriteLine();

            // Обратить порядок следования элементов...
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            // Сортировка массива
            Array.Sort(gothicBands);
            Console.WriteLine("-> Array sort");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            string[] secondGothicBands = new string[gothicBands.Length];
            gothicBands.CopyTo(secondGothicBands, 0);
            Console.WriteLine("-> CopyTo another array");
            Console.WriteLine("-> Array 1");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(secondGothicBands[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("-> Array 2");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            // Удалить все элементы кроме первого.
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, gothicBands.Length - 1);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();



            double result = 2 * 2 * 2;

            Console.WriteLine(result);

            double niceResult = Math.Pow(2, 3);

            Console.WriteLine(niceResult);


            Console.ReadKey();
        }
    }
}
