using System;

namespace Recursion
{
    class Program
    {
        public static int FindFactorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return FindFactorial(n - 1) * n;
        }

        static void Main(string[] args)
        {
            int fact = FindFactorial(10);
        }
    }
}
