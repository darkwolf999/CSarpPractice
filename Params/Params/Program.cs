using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CalculateAvg(5,4,4,545,546,564,65,546,54));
            
            Console.ReadKey();
        }

        static int CalculateAvg(params int[] values)
        {
            int sum = 0;
            if (values.Length == 0)
                return sum;
            foreach (int value in values)
                sum += value;
            return sum / values.Length;
        }
    }
}
