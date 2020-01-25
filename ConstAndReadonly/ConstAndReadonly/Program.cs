using System;

namespace ConstAndReadonly
{
    class Program
    {
        class MyMathClass
        {
            public const double constPI = 3.14;
            // Поля только для чтения могут присваиваться
            // в конструкторах, но больше нигде
            public readonly double readonlyPI;

            public MyMathClass()
            {
                readonlyPI = 3.14;
            }

            // Ошибка! Любая попытка выполнить присваивание полю, помеченному как readonly, 
            //за пределами конструктора приведет к ошибке на этапе компиляции:
            public void ChangePI()
            {
                //readonlyPI = 3.14444 ; 
            }

            static void LocalConstStringVanable()
            {
                // Доступ к локальным константным данным можно получать напрямую,
                const string fixedStr = "Fixed string Data";
                Console.WriteLine(fixedStr);
                // Ошибка!
                // fixedStr = "This will not work!";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.constPI);
            // Ошибка! Константу изменять нельзя!
            // MyMathClass.PI = 3.1444;
            Console.ReadLine();
        }
    }
}
