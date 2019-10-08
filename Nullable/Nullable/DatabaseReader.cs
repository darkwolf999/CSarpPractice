using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class DatabaseReader
    {
        public int? NumValue = null;
        public bool? boolValue = false;

        public int? GetIntFromDB()
        {
            return NumValue;
        }

        public bool? GetBoolFromDB()
        {
            return boolValue;
        }
    }
}
