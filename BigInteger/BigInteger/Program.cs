using System;
using System.Numerics;

namespace BigIntegerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Use Biglnteger:");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            // значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            // biggy - четное?
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            // biggy - степень 2?
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            // значение reallyBig
            
            Console.Read();
        }
    }
}
