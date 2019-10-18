using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWriterComposition
{
    class TextEditor
    {
        public IWriter Writer { get; set; }

        public void WriteText(string text)
        {
            text += " some";
            Writer.Write(text);
        }
    }
}
