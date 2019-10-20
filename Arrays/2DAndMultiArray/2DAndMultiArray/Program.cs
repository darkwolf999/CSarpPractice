using System;

namespace _2DAndMultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // Прямоугольный многомерный массив.
            int m = 3, n = 3;
            int[,] myMatrix = new int[m, n];


            Console.WriteLine(myMatrix.Length);  

            // Заполнить массив
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    myMatrix[i, j] = i * n + j;

            // Вывести содержимое массива
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }



            Console.WriteLine();





            var array1D = new[] { 10, 24, 67, 45 };

            var array2D = new[,] { { 1.1, 2.2 }, { 3.3, 4.4 }, { 5.5, 6.6 } };

            var arrayJagged = new[] { new[] { 1, 2, 3, 4 },
                                      new[] { 9, 8, 7 }, 
                                      new[] { 11, 12, 13, 14, 15 } };




            Console.WriteLine();






            Console.WriteLine("=> Jagged multidimensional array."); // Зубчатый многомерный массив (т.е. массив массивов)
            int size = 40;

            // Создать зубчатый массив.
            int[][] myJagArray = new int[size][]; // Здесь мы имеем массив из size разных массивов
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
