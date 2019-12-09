using System;

namespace Separators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Use Digit Separators:");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double:");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);

            Console.WriteLine("=> Use Binary Literals:");
            Console.WriteLine("Sixteen: {0}", 0b0001_0000);
            Console.WriteLine("Thirty Two: {0}", 0b0010_0000);
            Console.WriteLine("Sixty Four: {0}", 0b0100_0000);
        }
    }
}
