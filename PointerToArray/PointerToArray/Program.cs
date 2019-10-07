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

            Console.ReadKey();
        }
    }
}
