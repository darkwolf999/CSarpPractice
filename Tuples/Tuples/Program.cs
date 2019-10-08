using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int, string) sampleValues = ("a", 4, "b");
            var values = ("a", 4, "b"); // same

            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");


            var namedValues = (kek : "a", sas : 4, lol : "b");

            Console.WriteLine($"First item: {namedValues.kek}");
            Console.WriteLine($"Second item: {namedValues.sas}");
            Console.WriteLine($"Third item: {namedValues.lol}");

            Console.WriteLine($"First item: {namedValues.Item1}");
            Console.WriteLine($"Second item: {namedValues.Item2}");
            Console.WriteLine($"Third item: {namedValues.Item3}");



            var foo = new { Propl = "first", Prop2 = "second" };
            var bar = (foo.Propl, foo.Prop2);

            Console.WriteLine($"{bar.Propl};{bar.Prop2}");



            var samples = FillThisValues();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");



            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first}:{last}");





            Point myPoint = new Point(7, 5);
            var pointValues = myPoint.Deconstruct();
            Console.WriteLine($"X is: { pointValues.XPos}");
            Console.WriteLine($"Y is: { pointValues.YPos}");



            Console.Read();
        }

        static (int a, string b, bool c) FillThisValues()
        {
            return (9, "Enjoy", true);
        }

        static (string first, string middle, string last) SplitNames(string fullName)
        {
            // Действия, необходимые для расщепления полного имени,
            return ("Philip", "F", "Japikse");
        }
    }
}
