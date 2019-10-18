using System;

namespace InterfaceWriterComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor1 = new TextEditor();

            editor1.Writer = new StandartWriter();
            editor1.WriteText("kek");

            editor1.Writer = new BracesWriter();
            editor1.WriteText("kek");



            IWriter w1 = new BracesWriter();
            w1.Write("u");


            Console.Read();
        }
    }
}
