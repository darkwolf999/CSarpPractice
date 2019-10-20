using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "priveti";
            string str2 = "priveti0";

            Console.WriteLine(str);

            str = str.ToUpper();

            Console.WriteLine(str);

            str = str.ToLower();

            Console.WriteLine(str);

            Console.WriteLine(str.CompareTo(str2));


            char[] arrChar = { 'c', 'a', 'r' };
            string strFromCharArr = new string(arrChar);
            Console.WriteLine(strFromCharArr);


            Console.Read();
        }
    }
}
