using System;

namespace ShortMethods
{
    class Program
    {
        static void someFunc() => Console.WriteLine("This is short method");

        static void Main(string[] args)
        {
            someFunc();
        }
    }
}
