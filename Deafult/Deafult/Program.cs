using System;

namespace Deafult
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = default;
            double d = default;
            char c = default;
            string s = default;
            bool b = default;

            Console.WriteLine($"int: {i}\ndouble: {d}\nchar: {c}\nstring: {s}\nbool: {b}");

            Console.Read();
        }
    }
}
