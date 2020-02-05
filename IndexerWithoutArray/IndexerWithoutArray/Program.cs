using System;

namespace IndexerWithoutArray
{
    class PowOfTwo
    {
        public int this[int index]
        {
            get
            {
                return PowFunc(index);
            }
        }

        private int PowFunc(int index)
        {
            int result = 1;

            for (int i = 0; i < index; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PowOfTwo p = new PowOfTwo();

            Console.WriteLine(p[10]);
        }
    }
}
