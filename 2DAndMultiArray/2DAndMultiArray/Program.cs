using System;

namespace _2DAndMultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // Прямоугольный многомерный массив.
            int[,] myMatrix;
            int m = 10, n = 10;
            myMatrix = new int[m, n]; // Заполнить массив (3 * 4)
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    myMatrix[i, j] = i * j;
            // Вывести содержимое массива (3 * 4) .
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }






            Console.WriteLine();






            Console.WriteLine("=> Jagged multidimensional array."); // Зубчатый многомерный массив (т.е. массив массивов)
            int size = 40;
            int[][] myJagArray = new int[size][]; // Здесь мы имеем массив из 5 разных массивов
            // Создать зубчатый массив.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i+1];
            // Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
