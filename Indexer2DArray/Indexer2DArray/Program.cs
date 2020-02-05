using System;

namespace Indexer2DArray
{
    class FailSoftArray2D
    {
        private int[,] arr;
        private int rows, cols;
        private int Length;

        public FailSoftArray2D(int r, int c)
        {
            arr = new int[r, c];
            rows = r;
            cols = c;
            Length = r * c;
        }

        public int this[int rowIndex, int colIndex]
        {
            get
            {
                if (CheckBoundsArray(rowIndex, colIndex))
                    return arr[rowIndex, colIndex];
                else
                    return -1;
            }
            set
            {
                if (CheckBoundsArray(rowIndex, colIndex))
                    arr[rowIndex, colIndex] = value;
                else
                    Console.WriteLine("Out of bounds!!!");
            }
        }

        private bool CheckBoundsArray(int rowIndex, int colIndex)
        {
            return (rowIndex >= 0 && rowIndex < rows) && (colIndex >= 0 && colIndex < cols);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FailSoftArray2D fs = new FailSoftArray2D(3, 5);
            int x;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    fs[i, j] = j;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x = fs[i, j];
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
