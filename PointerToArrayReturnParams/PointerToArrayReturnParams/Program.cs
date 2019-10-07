using System;

namespace PointerToArrayReturnParams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "ass", "we", "can" };

            foreach(string element in arr)
                Console.WriteLine(element);

            ref string pointer = ref SampleRefReturn(arr, 1);
            pointer = "he";

            Console.WriteLine();

            foreach (string element in arr)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }




        static ref string SampleRefReturn(string[] array, int position)
        {
            return ref array[position];
        }




    }
}
