using System;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Array of Objects.");
            // Массив объектов может содержать все что угодно,
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Вывести тип и значение каждого элемента в массиве.
                Console.WriteLine("Туре: {0}, Value: {1}", obj.GetType(), obj);
            }

            Console.ReadKey();
        }
    }
}
