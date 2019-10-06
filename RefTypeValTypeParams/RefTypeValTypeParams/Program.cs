using System;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Start name", 12);

            p.Display();

            SendAPersonByValue(p);

            p.Display();

            SendAPersonByRef(ref p);

            p.Display();

            Console.ReadKey();
        }

        static void SendAPersonByValue(Person per)
        {
            per.age = 99999999;

            per = new Person("new name", 11111);
        }

        static void SendAPersonByRef(ref Person per)
        {
            per.age = 88888888;

            per = new Person("new name", 11111);
        }
    }
}
