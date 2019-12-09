using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Data type parsing: ");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0} ", b); // Вывод значения b
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0} ", d) ; // Вывод значения d
            int i = int.Parse("8") ;
            Console.WriteLine("Value of l: {0}", i); // Вывод значения i
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0} ", c); // Вывод значения с
            
            
            Console.WriteLine();


            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b1))
            {
                Console.WriteLine("Value of b: {0}", b1); // Вывод значения b
            }

            string value = "Hello";
            if (double.TryParse(value, out double d1))
            {
                Console.WriteLine("Value of d: {0}", d1); // Вывод значения d
            }
            else
            {
                // Преобразование потерпело неудачу
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }

            Console.Read();
        }
    }
}
