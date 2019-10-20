using System;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //Основные объявлеия массивов
            int[] arr1 = new int[100];
            //int[] arr2 = { 20, 15, 5};

            //Объявление с использованием неявной типизации
            var arr3 = new[] { 10, 10, 12, 13 };

            //Объявление массива объектов
            object[] arr4 = new object[3];
            arr4[0] = 3;
            arr4[1] = "kek";
            arr4[2] = 2.5;
            foreach (object element in arr4)
                Console.Write(element + " ");

            //Вывод количества элементов
            Console.WriteLine("\n" + "Длина массива: " + arr1.Length);

            //Инициализация 
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = i;

            //Вывод элементов на консоль
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");


            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            //Повторная инициализация
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = i + 100;

            //Повторный вывод элементов на консоль
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            //Если надо пройтись по всему массиву поочередно по каждому элементу
            foreach (int element in arr1)
                Console.Write(element + " ");

            Console.Read();

        }
    }
}
