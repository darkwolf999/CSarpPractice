using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWriterComposition
{
    class StandartWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    class BracesWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine("{" + text + "}");
        }
    }
}
