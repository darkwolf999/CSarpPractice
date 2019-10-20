using System;

namespace PointerToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "one", "two", "three" };
            ref string[] pointer = ref array;

            foreach (string element in array)
                Console.WriteLine(element);

            pointer[1] = "null";

            Console.WriteLine();

            foreach (string element in array)
                Console.WriteLine(element);

            for (int i = 0; i < pointer.Length; i++)
                pointer[i] = "null";

            Console.WriteLine();

            foreach (string element in array)
                Console.WriteLine(element);





            Console.WriteLine();

            int y = 10;
            Console.WriteLine(y);
            ref int x = ref y;
            x = 11;
            Console.WriteLine(x);
            Console.WriteLine(y);





            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 0, 0, 0, 0, 0 };


            Console.Write("arr1: ");
            foreach (int element in arr1)
                Console.Write(element + " ");

            Console.WriteLine();

            Console.Write("arr2: ");
            foreach (int element in arr2)
                Console.Write(element + " ");


            arr1 = arr2;
            Console.WriteLine();


            Console.Write("arr1: ");
            foreach (int element in arr1)
                Console.Write(element + " ");

            Console.WriteLine();

            Console.Write("arr2: ");
            foreach (int element in arr2)
                Console.Write(element + " ");

            arr1[0] = 11111;
            Console.WriteLine();

            Console.Write("arr1: ");
            foreach (int element in arr1)
                Console.Write(element + " ");

            Console.WriteLine();

            Console.Write("arr2: ");
            foreach (int element in arr2)
                Console.Write(element + " ");





            Console.ReadKey();
        }
    }
}
