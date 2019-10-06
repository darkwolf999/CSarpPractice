﻿using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Working with System.Array."); 

            // Инициализировать элементы при запуске
            string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sisters of Mercy"};

            // Вывести имена в порядке их объявления.
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            // Обратить порядок следования элементов...
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            // Удалить все элементы кроме первого.
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
