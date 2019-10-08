using System;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = null;     cant be null
            //bool b = null;    cant be null
            //double d = null;  cant be null
            string s = null;

            int? i = null;    // can be null
            bool? b = true;   // can be null
            b = null;
            double? d = 10.0; // can be null
            d = null;
            //string? s = null;  cant be null

            Nullable<int> i1 = null;
            Nullable<int>[] intArray = new Nullable<int>[10];





            DatabaseReader reader = new DatabaseReader();

            Console.WriteLine(reader.GetIntFromDB()); // nothing
            Console.WriteLine(reader.GetBoolFromDB()); // true

            Console.WriteLine();

            int? intVal = reader.GetIntFromDB();
            if (intVal.HasValue)
                Console.WriteLine(intVal.Value);
            else
                Console.WriteLine("undefined");

            bool? boolVal = reader.GetBoolFromDB();
            if (boolVal.HasValue)
                Console.WriteLine(boolVal.Value);
            else
                Console.WriteLine("undefined");





            int myData = reader.GetIntFromDB() ?? 100; // '?' after 'int' is optional 
            Console.WriteLine(myData);





            TesterMethod(null);
            Console.WriteLine();
            TesterMethod("one", "two");




            Console.Read();      
        }



        static void TesterMethod(params string[] args)
        {
            // Перед доступом к данным массива мы должны проверить его на равенство null!
            Console.WriteLine($"You sent me {args?.Length} arguments");

            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments");
        }
    }
}
