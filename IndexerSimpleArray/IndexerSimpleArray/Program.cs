using System;

namespace IndexerSimpleArray
{

    class FailSoftArray
    {
        int[] arr;
        public readonly int Length;

        public FailSoftArray(int len)
        {
            arr = new int[len];
            Length = len;
        }

        public int this[int index]
        {
            get
            {
                if (ArrBoundsCheck(index))
                    return arr[index];
                else
                    return -1;
            }
            set
            {
                if (ArrBoundsCheck(index))
                    arr[index] = value;
                else
                    Console.WriteLine("Out of bounds!!!");
            }
        }
        private bool ArrBoundsCheck(int index)
        {
            return (index >= 0 && index < Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FailSoftArray arr1 = new FailSoftArray(5);

            for (int i = 0; i  < 10; i ++)
            {
                arr1[i] = i * 10;
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("");

            //arr1.Length = 1000; //readonly член нельзя изменять напрямую
            Console.WriteLine($"Длина массива = {arr1.Length}");

            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr1[i]);
            }

        }
    }
}
